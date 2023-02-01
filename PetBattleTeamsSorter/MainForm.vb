Option Explicit On
Option Strict Off


Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.Data
Imports System.IO
Imports System.Linq
Imports System.Threading
Imports System.Threading.Tasks

Imports VB = Microsoft.VisualBasic


Public Class MainForm

#Region "Variables y objetos para uso exclusivo de la clase"
    Private LoadFoldersThread As Thread = Nothing
    Private LoadTeamsThread As Thread = Nothing
    Private SaveTeamsThread As Thread = Nothing
    Private SaveSingleFileThread As List(Of Thread) = Nothing

    Private MainHandler As LuaHandler = New LuaHandler()
    Private MainList As List(Of LuaTeam) = Nothing

    Private SelectIndex As Integer = 0
    Private IsFirstLoad As Boolean = False
#End Region

#Region "Eventos del formulario"

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblSource.Text = SOURCE_PATH
    End Sub

#End Region

#Region "Eventos de los controles del formulario"

    Private Sub butClose_Click(sender As Object, e As EventArgs) Handles butClose.Click
        End
    End Sub

    Private Sub butDetect_Click(sender As Object, e As EventArgs) Handles butDetect.Click
        If LoadFoldersThread IsNot Nothing Then
            Exit Sub
        End If

        LoadFoldersThread = New Thread(AddressOf LoadFolders)
        LoadFoldersThread.Priority = ThreadPriority.Lowest
        LoadFoldersThread.Start()
    End Sub

    Private Sub butLoad_Click(sender As Object, e As EventArgs) Handles butLoad.Click
        If LoadTeamsThread IsNot Nothing Then
            Exit Sub
        End If

        IsFirstLoad = True

        LoadTeamsThread = New Thread(AddressOf LoadTeams)
        LoadTeamsThread.Priority = ThreadPriority.Lowest
        LoadTeamsThread.Start()
    End Sub

    Private Sub butTop_Click(sender As Object, e As EventArgs) Handles butTop.Click
        MoveTo(1)
    End Sub

    Private Sub butUp_Click(sender As Object, e As EventArgs) Handles butUp.Click
        MoveTo(2)
    End Sub

    Private Sub butDown_Click(sender As Object, e As EventArgs) Handles butDown.Click
        MoveTo(3)
    End Sub

    Private Sub butBottom_Click(sender As Object, e As EventArgs) Handles butBottom.Click
        MoveTo(4)
    End Sub

    Private Sub butSort_Click(sender As Object, e As EventArgs) Handles butSort.Click
        SortTeams()
    End Sub

    Private Sub butSave_Click(sender As Object, e As EventArgs) Handles butSave.Click
        If SaveTeamsThread IsNot Nothing Then
            Exit Sub
        End If

        If MainList Is Nothing Then
            Exit Sub
        End If

        SaveTeamsThread = New Thread(AddressOf SaveTeams)
        SaveTeamsThread.Priority = ThreadPriority.Lowest
        SaveTeamsThread.Start()
    End Sub

#End Region

#Region "Funcionesy subrutinas"

    Private Sub LoadFolders()
        Dim oList As List(Of String)
        Dim oItem As ListViewItem

        Try
            ' Reinicia el estatus del proceso
            LabelText(lblMessage, "")

            ' Reinicia los controles
            ListViewItemsClear(lvFolders)

            ' Crea la referencia origen
            Dim oMainFolder As DirectoryInfo = New DirectoryInfo(SOURCE_PATH)
            oList = New List(Of String)

            For Each oFolder As DirectoryInfo In oMainFolder.GetDirectories()
                Select Case oFolder.Name
                    Case "SavedVariables"
                        ' Ignore
                    Case Else
                        oList.Add(oFolder.Name)
                End Select
            Next

            oList.Sort()
            For Each sFolder As String In oList
                oItem = New ListViewItem(sFolder)
                ListViewItemsAdd(lvFolders, oItem)
            Next
        Catch ex As Exception
            LabelText(lblMessage, ex.Message)
        Finally
            LoadFoldersThread = Nothing
        End Try
    End Sub

    Private Sub LoadTeams()
        If lvFolders.InvokeRequired Then
            Dim d As New LoadTeams_Callback(AddressOf LoadTeams)
            lvFolders.Invoke(d)
        Else
            ShowTeams()
        End If
    End Sub

    Private Sub MoveTo(Direction As Integer)
        Dim oTeam As LuaTeam
        Dim nIndex As Integer

        If LoadTeamsThread IsNot Nothing Then
            Exit Sub
        End If

        If MainList Is Nothing Then
            Exit Sub
        End If

        If lvTeams.SelectedIndices.Count <= 0 Then
            Exit Sub
        End If

        nIndex = lvTeams.SelectedIndices(0)
        oTeam = MainList(nIndex)
        MainList.RemoveAt(nIndex)

        Select Case Direction
            Case 1      ' Top
                nIndex = 0
            Case 2      ' Up
                nIndex = IIf(nIndex <= 0, 0, nIndex - 1)
            Case 3      ' Down
                nIndex = IIf(nIndex >= MainList.Count, MainList.Count, nIndex + 1)
            Case 4      ' Bottom
                nIndex = MainList.Count
        End Select

        MainList.Insert(nIndex, oTeam)

        If chkTopLocked.Checked Then
            RegroupTeams()
        End If

        SelectIndex = oTeam.Index

        ' Muestra la lista
        LoadTeamsThread = New Thread(AddressOf LoadTeams)
        LoadTeamsThread.Priority = ThreadPriority.Lowest
        LoadTeamsThread.Start()
    End Sub

    Private Sub RegroupTeams()
        Dim oNewList As List(Of LuaTeam) = New List(Of LuaTeam)

        Dim oLPart = From Team In MainList
                     Select Team
                     Where Team.Locked = True

        oNewList.AddRange(oLPart.ToList())

        Dim oNPart = From Team In MainList
                     Select Team
                     Where Team.Locked = False

        oNewList.AddRange(oNPart.ToList())

        MainList = oNewList
    End Sub

    Private Sub RenumTeams()
        Dim nIndex As Integer

        If MainList Is Nothing Then
            Exit Sub
        End If

        nIndex = 0
        For Each oTeam As LuaTeam In MainList
            nIndex += 1
            oTeam.Index = nIndex
        Next
    End Sub

    Private Sub SaveTeams()
        If lvFolders.InvokeRequired Then
            Dim d As New SaveTeams_Callback(AddressOf SaveTeams)
            lvFolders.Invoke(d)
        Else
            Dim oThread As Thread = Nothing
            Dim oItem As ListViewItem
            Dim nCount As Integer = 0

            Try
                SaveSingleFileThread = New List(Of Thread)

                If chkSave.Checked Then
                    For a As Integer = 0 To lvFolders.Items.Count - 1 Step 1
                        oItem = lvFolders.Items(a)

                        oThread = New Thread(AddressOf SaveSingleFile)
                        oThread.Priority = ThreadPriority.Lowest
                        SaveSingleFileThread.Add(oThread)
                        oThread.Start(oItem.Text)
                    Next
                Else
                    For a As Integer = 0 To lvFolders.SelectedItems.Count - 1 Step 1
                        oItem = lvFolders.SelectedItems(a)

                        oThread = New Thread(AddressOf SaveSingleFile)
                        oThread.Priority = ThreadPriority.Lowest
                        SaveSingleFileThread.Add(oThread)
                        oThread.Start(oItem.Text)
                    Next
                End If

                Do
                    Thread.Sleep(1)

                    nCount = 0
                    For a As Integer = 0 To SaveSingleFileThread.Count - 1 Step 1
                        If SaveSingleFileThread(a).ThreadState And ThreadState.Stopped = ThreadState.Stopped Then
                            nCount += 1
                        End If
                    Next

                    If nCount >= SaveSingleFileThread.Count Then
                        Exit Do
                    End If
                Loop

                LabelText(lblMessage, "SE GUARDARON " & Trim(CStr(nCount)) & " ARCHIVOS CON EXITO")
            Catch ex As Exception
                LabelText(lblMessage, ex.Message)
            Finally
                SaveTeamsThread = Nothing
                SaveSingleFileThread = Nothing

                GC.Collect()
            End Try
        End If
    End Sub

    Private Sub SaveSingleFile(FolderName As String)
        Dim oHandler As LuaHandler
        Dim sPath As String
        Dim sFile As String
        Dim sBackup As String

        Try
            ' Construye el path para manejo de archivos
            sPath = Path.Combine(SOURCE_PATH, FolderName, "SavedVariables")
            sFile = Path.Combine(sPath, SOURCE_FILE)
            sBackup = Path.Combine(sPath, BACKUP_FILE)

            ' Crea el manejador y carga el archivo
            oHandler = New LuaHandler()
            oHandler.LoadFile(sFile)

            ' Crea el backup
            If File.Exists(sBackup) Then
                File.Delete(sBackup)
            End If

            File.Copy(sFile, sBackup)

            ' Guarda el nuevo archivo
            oHandler.SaveFile(sFile, MainList)
        Catch ex As Exception
            LabelText(lblMessage, ex.Message)
        End Try
    End Sub

    Private Sub ShowTeams()
        Dim oLocked As ListViewGroup
        Dim oNormal As ListViewGroup
        Dim oItem As ListViewItem
        Dim sPath As String
        Dim sFile As String
        Dim nCount As Integer

        Try
            ' Reinicia el estatus del proceso
            LabelText(lblMessage, "")

            ' Recupera el item seleccionado
            oItem = lvFolders.SelectedItems(0)

            ' Construye el path de origen
            sPath = Path.Combine(SOURCE_PATH, oItem.Text, "SavedVariables")
            sFile = Path.Combine(sPath, SOURCE_FILE)

            If IsFirstLoad Then
                MainHandler.LoadFile(sFile)
                MainList = MainHandler.GetTeamList()

                If chkTopLocked.Checked Then
                    RegroupTeams()
                    RenumTeams()
                End If
            End If

            ' Carga los equipos y muestra la lista
            ListViewItemsClear(lvTeams)
            ListViewGroupsClear(lvTeams)

            If chkTopLocked.Checked Then
                oLocked = New ListViewGroup("Fijos")
                oNormal = New ListViewGroup("Abiertos")

                ListViewGroupsAdd(lvTeams, oLocked)
                ListViewGroupsAdd(lvTeams, oNormal)
            Else
                oLocked = New ListViewGroup("Equipos")
                oNormal = oLocked

                ListViewGroupsAdd(lvTeams, oLocked)
            End If

            ' Muestra la lista
            nCount = 0
            For Each oTeam As LuaTeam In MainList
                If oTeam.Locked Then
                    oItem = New ListViewItem(oTeam.Name, oLocked)
                    oItem.SubItems.Add("Fijo")
                    oItem.SubItems.Add(oTeam.Index)
                Else
                    oItem = New ListViewItem(oTeam.Name, oNormal)
                    oItem.SubItems.Add("")
                    oItem.SubItems.Add(oTeam.Index)
                End If

                oItem.Tag = oTeam
                ListViewItemsAdd(lvTeams, oItem)

                nCount += 1
                LabelText(lblCount, Trim(CStr(nCount)) & " / " & Trim(CStr(MainList.Count)) & " equipos cargados ")
            Next

            If SelectIndex >= 1 Then
                ListViewSelectIndex(lvTeams, SelectIndex)
            End If
        Catch ex As Exception
            LabelText(lblMessage, ex.Message)
        Finally
            LoadTeamsThread = Nothing
            SelectIndex = 0
            IsFirstLoad = False
        End Try
    End Sub

    Private Sub SortTeams()
        If LoadTeamsThread IsNot Nothing Then
            Exit Sub
        End If

        If MainList Is Nothing Then
            Exit Sub
        End If

        ' Ordena la lista
        Dim oSorted = From Team In MainList
                      Select Team
                      Order By Team.Name Ascending

        MainList = oSorted.ToList()

        If chkTopLocked.Checked Then
            RegroupTeams()
        End If

        ' Muestra la lista
        LoadTeamsThread = New Thread(AddressOf LoadTeams)
        LoadTeamsThread.Priority = ThreadPriority.Lowest
        LoadTeamsThread.Start()
    End Sub

#End Region

#Region "Eventos delegados a traves de subprocesos"

    Private Delegate Sub LoadTeams_Callback()
    Private Delegate Sub SaveTeams_Callback()

    Private Delegate Sub LabelText_Callback(SourceObject As Label, Text As String)
    Private Delegate Sub ListViewGroupsAdd_Callback(SourceObject As ListView, Group As ListViewGroup)
    Private Delegate Sub ListViewGroupsClear_Callback(SourceObject As ListView)
    Private Delegate Sub ListViewItemsAdd_Callback(SourceObject As ListView, Item As ListViewItem)
    Private Delegate Sub ListViewItemsClear_Callback(SourceObject As ListView)
    Private Delegate Sub ListViewSelectIndex_Callback(SourceObject As ListView, Index As Integer)

    Private Sub LabelText(SourceObject As Label, Text As String)
        If SourceObject.InvokeRequired Then
            Dim d As New LabelText_Callback(AddressOf LabelText)
            SourceObject.Invoke(d, New Object() {SourceObject, Text})
        Else
            With SourceObject
                .Text = Text
                '.Refresh()
            End With
        End If
    End Sub

    Private Sub ListViewGroupsAdd(SourceObject As ListView, Group As ListViewGroup)
        If SourceObject.InvokeRequired Then
            Dim d As New ListViewGroupsAdd_Callback(AddressOf ListViewGroupsAdd)
            SourceObject.Invoke(d, New Object() {SourceObject, Group})
        Else
            With SourceObject
                .Groups.Add(Group)
                '.Refresh()
            End With
        End If
    End Sub

    Private Sub ListViewGroupsClear(SourceObject As ListView)
        If SourceObject.InvokeRequired Then
            Dim d As New ListViewGroupsClear_Callback(AddressOf ListViewGroupsClear)
            SourceObject.Invoke(d, New Object() {SourceObject})
        Else
            With SourceObject
                .Groups.Clear()
                '.Refresh()
            End With
        End If
    End Sub

    Private Sub ListViewItemsAdd(SourceObject As ListView, Item As ListViewItem)
        If SourceObject.InvokeRequired Then
            Dim d As New ListViewItemsAdd_Callback(AddressOf ListViewItemsAdd)
            SourceObject.Invoke(d, New Object() {SourceObject, Item})
        Else
            With SourceObject
                .Items.Add(Item)
                '.Refresh()
            End With
        End If
    End Sub

    Private Sub ListViewItemsClear(SourceObject As ListView)
        If SourceObject.InvokeRequired Then
            Dim d As New ListViewItemsClear_Callback(AddressOf ListViewItemsClear)
            SourceObject.Invoke(d, New Object() {SourceObject})
        Else
            With SourceObject
                .Items.Clear()
                '.Refresh()
            End With
        End If
    End Sub

    Private Sub ListViewSelectIndex(SourceObject As ListView, Index As Integer)
        If SourceObject.InvokeRequired Then
            Dim d As New ListViewSelectIndex_Callback(AddressOf ListViewSelectIndex)
            SourceObject.Invoke(d, New Object() {SourceObject, Index})
        Else
            With SourceObject
                For a As Integer = 0 To SourceObject.Items.Count - 1 Step 1
                    If SourceObject.Items(a).Tag.Index = Index Then
                        SourceObject.Items(a).Selected = True
                        SourceObject.Items(a).EnsureVisible()
                        Exit For
                    End If
                Next
                '.Refresh()
            End With
        End If
    End Sub

#End Region

End Class


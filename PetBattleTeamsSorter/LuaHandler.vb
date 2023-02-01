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


Imports MoonSharp
Imports MoonSharp.Interpreter


Public Class LuaHandler
    Private Const Teams_Key As String = "PetBattleTeamsDB"
    Private Const Settings_Key As String = "PetBattleTeamsSettings"

    Private TeamsObject As DynValue = Nothing
    Private SettingsObject As DynValue = Nothing

    Public FileName As String = ""
    Public FileBuffer As String = ""

    Private WriteBuffer As String = ""

    Public Function GetTeamList() As List(Of LuaTeam)
        Dim Teams As Table = TeamsObject.Table("namespaces")("TeamManager")("global")("teams")
        Dim Team As Table
        Dim TeamItem As LuaTeam
        Dim TeamList As List(Of LuaTeam)
        Dim sKey As String

        TeamList = New List(Of LuaTeam)

        For a As Integer = 1 To Teams.Length Step 1
            Team = Teams(a)
            TeamItem = New LuaTeam()
            TeamItem.Index = a
            TeamItem.SourceTable = Team

            For Each oKey As DynValue In Team.Keys
                sKey = oKey.String
                Select Case sKey
                    Case "name"
                        TeamItem.Name = Team(sKey)
                    Case "locked"
                        TeamItem.Locked = Team(sKey)
                    Case Else
                        ' Do nothing
                End Select
            Next

            TeamList.Add(TeamItem)
        Next

        Return TeamList
    End Function

    Public Sub LoadFile(FullFileName As String)
        ' Carga el archivo
        FileBuffer = ""

        Using oFile As FileStream = File.OpenRead(FullFileName)
            oFile.Position = 0

            Using oReader As StreamReader = New StreamReader(oFile)
                FileBuffer = oReader.ReadToEnd()
            End Using

            oFile.Close()
        End Using

        FileName = FullFileName

        ' Carga los equipos
        TeamsObject = Script.RunString(FileBuffer & vbCrLf & "return " & Teams_Key & vbCrLf)
        SettingsObject = Script.RunString(FileBuffer & vbCrLf & "return " & Settings_Key & vbCrLf)
    End Sub

    Public Sub SaveFile(FullFileName As String, TeamList As List(Of LuaTeam))
        ' Crea el contenido del archivo
        WriteBuffer = "" & vbCrLf

        WriteValue(Teams_Key, TeamsObject, TeamList, 0, False, False, False, False, Nothing)
        WriteValue(Settings_Key, SettingsObject, TeamList, 0, False, False, False, False, Nothing)

        ' Escribe el archivo en disco
        If File.Exists(FullFileName) Then
            File.Delete(FullFileName)
        End If

        Using oFile As FileStream = File.OpenWrite(FullFileName)
            oFile.Position = 0

            Using oWriter As StreamWriter = New StreamWriter(oFile)
                oWriter.Write(WriteBuffer)
                oWriter.Flush()
            End Using

            oFile.Close()
        End Using

        ' Limpia el buffer
        WriteBuffer = ""
    End Sub

    Private Sub SortProfiles(TablePairs As IEnumerable(Of TablePair), TeamList As List(Of LuaTeam), TabCount As Integer, IsTeamManagerOpen As Boolean, IsGlobalOpen As Boolean, IsTeamsOpen As Boolean, IsTeamDetail As Boolean, Counter As LuaEnum)
        Dim oProfile = From oPair In TablePairs
                       Select oPair
                       Order By Split(oPair.Key.String, " - ")(1) Ascending,
                           Split(oPair.Key.String, " - ")(0) Ascending

        Dim oPairs = oProfile.ToList()

        For Each oPair In oPairs
            WriteValue(oPair.Key.String, oPair.Value, TeamList, TabCount, IsTeamManagerOpen, IsGlobalOpen, IsTeamsOpen, IsTeamDetail, Counter)
        Next
    End Sub

    Private Sub WriteValue(KeyName As String, SourceValue As DynValue, TeamList As List(Of LuaTeam), TabCount As Integer, IsTeamManagerOpen As Boolean, IsGlobalOpen As Boolean, IsTeamsOpen As Boolean, IsTeamDetail As Boolean, Counter As LuaEnum)
        Select Case SourceValue.Type
            Case DataType.Boolean
                WriteBoolean(KeyName, SourceValue.Boolean, TabCount, Counter)
            Case DataType.ClrFunction
                WriteBuffer &= "*** Tipo no indentificado (ClrFunction)" & vbCrLf
            Case DataType.Function
                WriteBuffer &= "*** Tipo no indentificado (Function)" & vbCrLf
            Case DataType.Nil
                WriteNil(KeyName, TabCount, Counter)
            Case DataType.Number
                WriteNumber(KeyName, SourceValue.Number, TabCount, Counter)
            Case DataType.String
                WriteString(KeyName, SourceValue.String, TabCount, Counter)
            Case DataType.Table
                WriteTable(KeyName, SourceValue.Table, TeamList, TabCount, IsTeamManagerOpen, IsGlobalOpen, IsTeamsOpen, IsTeamDetail, Counter)
            Case DataType.TailCallRequest
                WriteBuffer &= "*** Tipo no indentificado (TailCallRequest)" & vbCrLf
            Case DataType.Thread
                WriteBuffer &= "*** Tipo no indentificado (Thread)" & vbCrLf
            Case DataType.Tuple
                WriteBuffer &= "*** Tipo no indentificado (Tuple)" & vbCrLf
            Case DataType.UserData
                WriteBuffer &= "*** Tipo no indentificado (UserData)" & vbCrLf
            Case DataType.Void
                WriteBuffer &= "*** Tipo no indentificado (Void)" & vbCrLf
            Case DataType.YieldRequest
                WriteBuffer &= "*** Tipo no indentificado (YieldRequest)" & vbCrLf
            Case Else
                ' Do nothing
        End Select
    End Sub

    Private Sub WriteBoolean(KeyName As String, FlagValue As Double, TabCount As Integer, Counter As LuaEnum)
        Dim sTabs As String = New String(vbTab, TabCount)

        WriteBuffer &= sTabs
        If Not String.IsNullOrEmpty(KeyName) Then
            WriteBuffer &= IIf(TabCount <= 0, "", "[""")
            WriteBuffer &= KeyName
            WriteBuffer &= IIf(TabCount <= 0, "", """]")
            WriteBuffer &= " = "
        End If
        WriteBuffer &= IIf(FlagValue, "true", "false") & IIf(TabCount > 0, ",", "")
        If Counter IsNot Nothing Then
            WriteBuffer &= " -- [" & Counter.GetNext() & "]"
        End If
        WriteBuffer &= vbCrLf
    End Sub

    Private Sub WriteNil(KeyName As String, TabCount As Integer, Counter As LuaEnum)
        Dim sTabs As String = New String(vbTab, TabCount)

        WriteBuffer &= sTabs
        If Not String.IsNullOrEmpty(KeyName) Then
            WriteBuffer &= IIf(TabCount <= 0, "", "[""")
            WriteBuffer &= KeyName
            WriteBuffer &= IIf(TabCount <= 0, "", """]")
            WriteBuffer &= " = "
        End If
        WriteBuffer &= "nil" & IIf(TabCount > 0, ",", "")
        If Counter IsNot Nothing Then
            WriteBuffer &= " -- [" & Counter.GetNext() & "]"
        End If
        WriteBuffer &= vbCrLf
    End Sub

    Private Sub WriteNumber(KeyName As String, NumberValue As Double, TabCount As Integer, Counter As LuaEnum)
        Dim sTabs As String = New String(vbTab, TabCount)

        WriteBuffer &= sTabs
        If Not String.IsNullOrEmpty(KeyName) Then
            WriteBuffer &= IIf(TabCount <= 0, "", "[""")
            WriteBuffer &= KeyName
            WriteBuffer &= IIf(TabCount <= 0, "", """]")
            WriteBuffer &= " = "
        End If
        WriteBuffer &= "" & NumberValue & IIf(TabCount > 0, ",", "")
        If Counter IsNot Nothing Then
            WriteBuffer &= " -- [" & Counter.GetNext() & "]"
        End If
        WriteBuffer &= vbCrLf
    End Sub

    Private Sub WriteString(KeyName As String, StringValue As String, TabCount As Integer, Counter As LuaEnum)
        Dim sTabs As String = New String(vbTab, TabCount)

        WriteBuffer &= sTabs
        If Not String.IsNullOrEmpty(KeyName) Then
            WriteBuffer &= IIf(TabCount <= 0, "", "[""")
            WriteBuffer &= KeyName
            WriteBuffer &= IIf(TabCount <= 0, "", """]")
            WriteBuffer &= " = "
        End If
        WriteBuffer &= """"
        WriteBuffer &= StringValue
        WriteBuffer &= """"
        WriteBuffer &= IIf(TabCount > 0, ",", "")
        If Counter IsNot Nothing Then
            WriteBuffer &= " -- [" & Counter.GetNext() & "]"
        End If
        WriteBuffer &= vbCrLf
    End Sub

    Private Sub WriteTable(KeyName As String, SourceTable As Table, TeamList As List(Of LuaTeam), TabCount As Integer, IsTeamManagerOpen As Boolean, IsGlobalOpen As Boolean, IsTeamsOpen As Boolean, IsTeamDetail As Boolean, Counter As LuaEnum)
        Dim oPair As TablePair
        Dim oCounter As LuaEnum
        Dim oTeam As LuaTeam
        Dim sTabs As String = New String(vbTab, TabCount)

        WriteBuffer &= sTabs
        If Not String.IsNullOrEmpty(KeyName) Then
            WriteBuffer &= IIf(TabCount <= 0, "", "[""")
            WriteBuffer &= KeyName
            WriteBuffer &= IIf(TabCount <= 0, "", """]")
            WriteBuffer &= " = "
        End If
        WriteBuffer &= "{" & vbCrLf

        Select Case KeyName
            Case "profileKeys"
                SortProfiles(SourceTable.Pairs, TeamList, TabCount + 1, IsTeamManagerOpen, IsGlobalOpen, IsTeamsOpen, IsTeamDetail, Counter)
            Case "TeamManager"
                For Each oPair In SourceTable.Pairs
                    WriteValue(oPair.Key.String, oPair.Value, TeamList, TabCount + 1, True, False, False, IsTeamDetail, Nothing)
                Next
            Case "global"
                If IsTeamManagerOpen Then
                    For Each oPair In SourceTable.Pairs
                        WriteValue(oPair.Key.String, oPair.Value, TeamList, TabCount + 1, True, True, False, IsTeamDetail, Nothing)
                    Next
                Else
                    For Each oPair In SourceTable.Pairs
                        WriteValue(oPair.Key.String, oPair.Value, TeamList, TabCount + 1, False, False, False, IsTeamDetail, Nothing)
                    Next
                End If
            Case "teams"
                If IsGlobalOpen Then
                    oCounter = New LuaEnum()
                    For Each oTeam In TeamList
                        WriteTeam(oTeam, TabCount + 1, oCounter)
                    Next
                Else
                    For Each oPair In SourceTable.Pairs
                        WriteValue(oPair.Key.String, oPair.Value, TeamList, TabCount + 1, False, False, False, IsTeamDetail, Nothing)
                    Next
                End If
            Case "abilities", "enabled"
                If IsTeamDetail Then
                    oCounter = New LuaEnum()
                    For Each oPair In SourceTable.Pairs
                        WriteValue(oPair.Key.String, oPair.Value, TeamList, TabCount + 1, False, False, False, IsTeamDetail, oCounter)
                    Next
                Else
                    For Each oPair In SourceTable.Pairs
                        WriteValue(oPair.Key.String, oPair.Value, TeamList, TabCount + 1, False, False, False, IsTeamDetail, Nothing)
                    Next
                End If
            Case Else
                For Each oPair In SourceTable.Pairs
                    WriteValue(oPair.Key.String, oPair.Value, TeamList, TabCount + 1, False, False, False, IsTeamDetail, Nothing)
                Next
        End Select

        WriteBuffer &= sTabs
        WriteBuffer &= "}"
        WriteBuffer &= IIf(TabCount > 0, ",", "")
        If Counter IsNot Nothing Then
            WriteBuffer &= " -- [" & Counter.GetNext() & "]"
        End If
        WriteBuffer &= vbCrLf
    End Sub

    Private Sub WriteTeam(SourceTeam As LuaTeam, TabCount As Integer, Counter As LuaEnum)
        Dim sTabs As String = New String(vbTab, TabCount)

        ' Escribe la apertura del equipo
        WriteBuffer &= sTabs
        WriteBuffer &= "{" & vbCrLf

        ' Escribe los detalles sin nombre
        WriteTeamByType(SourceTeam, DataType.Number, TabCount + 1)

        ' Escribe los detalles con nombre
        WriteTeamByType(SourceTeam, DataType.String, TabCount + 1)

        ' Escribe el cierre del equipo
        WriteBuffer &= sTabs
        WriteBuffer &= "}"
        WriteBuffer &= IIf(TabCount > 0, ",", "")
        If Counter IsNot Nothing Then
            WriteBuffer &= " -- [" & Counter.GetNext() & "]"
        End If
        WriteBuffer &= vbCrLf
    End Sub

    Private Sub WriteTeamByType(SourceTeam As LuaTeam, TeamType As DataType, TabCount As Integer)
        Dim oCounter As LuaEnum
        Dim sTabs As String = New String(vbTab, TabCount)

        ' Filtra los elementos
        Dim oTyped = From oPair In SourceTeam.SourceTable.Pairs
                     Select oPair
                     Where oPair.Key.Type = TeamType

        Dim oListed = oTyped.ToList()
        Dim oItem As TablePair

        ' Escribe los elementos en buffer
        oCounter = New LuaEnum()
        For Each oItem In oListed
            Select Case TeamType
                Case DataType.Number
                    WriteValue("", oItem.Value, Nothing, TabCount, False, False, False, True, oCounter)
                Case DataType.String
                    WriteValue(oItem.Key.String, oItem.Value, Nothing, TabCount, False, False, False, True, Nothing)
                Case Else
                    ' Do nothing
            End Select
        Next
    End Sub
End Class

Public Class LuaEnum
    Public Counter As Integer = 0

    Public Function GetNext() As Integer
        Counter += 1
        Return Counter
    End Function
End Class

Public Class LuaTeam
    Public Name As String = ""
    Public Locked As Boolean = False
    Public Index As Integer = 0
    Public SourceTable As Table = Nothing
End Class



<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.tlpMain = New System.Windows.Forms.TableLayoutPanel()
        Me.gbDetect = New System.Windows.Forms.GroupBox()
        Me.tlpDetect = New System.Windows.Forms.TableLayoutPanel()
        Me.butDetect = New System.Windows.Forms.Button()
        Me.butLoad = New System.Windows.Forms.Button()
        Me.lvFolders = New System.Windows.Forms.ListView()
        Me.chFolder = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.gbSource = New System.Windows.Forms.GroupBox()
        Me.lblSource = New System.Windows.Forms.Label()
        Me.gbTeams = New System.Windows.Forms.GroupBox()
        Me.gbOptions = New System.Windows.Forms.GroupBox()
        Me.butClose = New System.Windows.Forms.Button()
        Me.lblMessage = New System.Windows.Forms.Label()
        Me.tlpTeams = New System.Windows.Forms.TableLayoutPanel()
        Me.lvTeams = New System.Windows.Forms.ListView()
        Me.chName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chType = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.tlpOptions = New System.Windows.Forms.TableLayoutPanel()
        Me.chkTopLocked = New System.Windows.Forms.CheckBox()
        Me.butSort = New System.Windows.Forms.Button()
        Me.lblSortOptions = New System.Windows.Forms.Label()
        Me.lblSaveOptions = New System.Windows.Forms.Label()
        Me.chkSave = New System.Windows.Forms.CheckBox()
        Me.butSave = New System.Windows.Forms.Button()
        Me.lblMove = New System.Windows.Forms.Label()
        Me.butTop = New System.Windows.Forms.Button()
        Me.butUp = New System.Windows.Forms.Button()
        Me.butDown = New System.Windows.Forms.Button()
        Me.butBottom = New System.Windows.Forms.Button()
        Me.lblCount = New System.Windows.Forms.Label()
        Me.chIndex = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.tlpMain.SuspendLayout()
        Me.gbDetect.SuspendLayout()
        Me.tlpDetect.SuspendLayout()
        Me.gbSource.SuspendLayout()
        Me.gbTeams.SuspendLayout()
        Me.gbOptions.SuspendLayout()
        Me.tlpTeams.SuspendLayout()
        Me.tlpOptions.SuspendLayout()
        Me.SuspendLayout()
        '
        'tlpMain
        '
        Me.tlpMain.ColumnCount = 25
        Me.tlpMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10.0!))
        Me.tlpMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.333332!))
        Me.tlpMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10.0!))
        Me.tlpMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.333332!))
        Me.tlpMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10.0!))
        Me.tlpMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.333332!))
        Me.tlpMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10.0!))
        Me.tlpMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.333332!))
        Me.tlpMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10.0!))
        Me.tlpMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.333332!))
        Me.tlpMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10.0!))
        Me.tlpMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.333332!))
        Me.tlpMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10.0!))
        Me.tlpMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.333332!))
        Me.tlpMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10.0!))
        Me.tlpMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.333332!))
        Me.tlpMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10.0!))
        Me.tlpMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.333332!))
        Me.tlpMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10.0!))
        Me.tlpMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.333332!))
        Me.tlpMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10.0!))
        Me.tlpMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.333332!))
        Me.tlpMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10.0!))
        Me.tlpMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.333332!))
        Me.tlpMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10.0!))
        Me.tlpMain.Controls.Add(Me.gbDetect, 1, 5)
        Me.tlpMain.Controls.Add(Me.gbSource, 1, 1)
        Me.tlpMain.Controls.Add(Me.gbTeams, 7, 5)
        Me.tlpMain.Controls.Add(Me.gbOptions, 17, 5)
        Me.tlpMain.Controls.Add(Me.butClose, 21, 7)
        Me.tlpMain.Controls.Add(Me.lblMessage, 1, 3)
        Me.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpMain.Location = New System.Drawing.Point(0, 0)
        Me.tlpMain.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpMain.Name = "tlpMain"
        Me.tlpMain.RowCount = 9
        Me.tlpMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10.0!))
        Me.tlpMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.tlpMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10.0!))
        Me.tlpMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.tlpMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10.0!))
        Me.tlpMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10.0!))
        Me.tlpMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.tlpMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10.0!))
        Me.tlpMain.Size = New System.Drawing.Size(1008, 729)
        Me.tlpMain.TabIndex = 0
        '
        'gbDetect
        '
        Me.tlpMain.SetColumnSpan(Me.gbDetect, 5)
        Me.gbDetect.Controls.Add(Me.tlpDetect)
        Me.gbDetect.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gbDetect.Location = New System.Drawing.Point(10, 130)
        Me.gbDetect.Margin = New System.Windows.Forms.Padding(0)
        Me.gbDetect.Name = "gbDetect"
        Me.gbDetect.Padding = New System.Windows.Forms.Padding(0)
        Me.gbDetect.Size = New System.Drawing.Size(239, 529)
        Me.gbDetect.TabIndex = 0
        Me.gbDetect.TabStop = False
        Me.gbDetect.Text = "Detectar"
        '
        'tlpDetect
        '
        Me.tlpDetect.BackColor = System.Drawing.Color.Transparent
        Me.tlpDetect.ColumnCount = 3
        Me.tlpDetect.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 5.0!))
        Me.tlpDetect.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpDetect.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 5.0!))
        Me.tlpDetect.Controls.Add(Me.butDetect, 1, 1)
        Me.tlpDetect.Controls.Add(Me.butLoad, 1, 3)
        Me.tlpDetect.Controls.Add(Me.lvFolders, 1, 5)
        Me.tlpDetect.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpDetect.Location = New System.Drawing.Point(0, 13)
        Me.tlpDetect.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpDetect.Name = "tlpDetect"
        Me.tlpDetect.RowCount = 7
        Me.tlpDetect.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5.0!))
        Me.tlpDetect.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlpDetect.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5.0!))
        Me.tlpDetect.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlpDetect.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5.0!))
        Me.tlpDetect.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpDetect.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5.0!))
        Me.tlpDetect.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpDetect.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpDetect.Size = New System.Drawing.Size(239, 516)
        Me.tlpDetect.TabIndex = 0
        '
        'butDetect
        '
        Me.butDetect.Dock = System.Windows.Forms.DockStyle.Fill
        Me.butDetect.Location = New System.Drawing.Point(5, 5)
        Me.butDetect.Margin = New System.Windows.Forms.Padding(0)
        Me.butDetect.Name = "butDetect"
        Me.butDetect.Size = New System.Drawing.Size(229, 30)
        Me.butDetect.TabIndex = 0
        Me.butDetect.Text = "Detectar carpetas"
        Me.butDetect.UseVisualStyleBackColor = True
        '
        'butLoad
        '
        Me.butLoad.Dock = System.Windows.Forms.DockStyle.Fill
        Me.butLoad.Location = New System.Drawing.Point(5, 40)
        Me.butLoad.Margin = New System.Windows.Forms.Padding(0)
        Me.butLoad.Name = "butLoad"
        Me.butLoad.Size = New System.Drawing.Size(229, 30)
        Me.butLoad.TabIndex = 1
        Me.butLoad.Text = "Cargar equipos"
        Me.butLoad.UseVisualStyleBackColor = True
        '
        'lvFolders
        '
        Me.lvFolders.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.chFolder})
        Me.lvFolders.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lvFolders.FullRowSelect = True
        Me.lvFolders.GridLines = True
        Me.lvFolders.HideSelection = False
        Me.lvFolders.Location = New System.Drawing.Point(5, 75)
        Me.lvFolders.Margin = New System.Windows.Forms.Padding(0)
        Me.lvFolders.MultiSelect = False
        Me.lvFolders.Name = "lvFolders"
        Me.lvFolders.Size = New System.Drawing.Size(229, 436)
        Me.lvFolders.TabIndex = 2
        Me.lvFolders.UseCompatibleStateImageBehavior = False
        Me.lvFolders.View = System.Windows.Forms.View.Details
        '
        'chFolder
        '
        Me.chFolder.Text = "Carpeta"
        Me.chFolder.Width = 200
        '
        'gbSource
        '
        Me.tlpMain.SetColumnSpan(Me.gbSource, 23)
        Me.gbSource.Controls.Add(Me.lblSource)
        Me.gbSource.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gbSource.Location = New System.Drawing.Point(10, 10)
        Me.gbSource.Margin = New System.Windows.Forms.Padding(0)
        Me.gbSource.Name = "gbSource"
        Me.gbSource.Padding = New System.Windows.Forms.Padding(0)
        Me.gbSource.Size = New System.Drawing.Size(986, 50)
        Me.gbSource.TabIndex = 1
        Me.gbSource.TabStop = False
        Me.gbSource.Text = "Carpeta principal"
        '
        'lblSource
        '
        Me.lblSource.BackColor = System.Drawing.Color.Transparent
        Me.lblSource.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblSource.ForeColor = System.Drawing.Color.Blue
        Me.lblSource.Location = New System.Drawing.Point(0, 13)
        Me.lblSource.Margin = New System.Windows.Forms.Padding(0)
        Me.lblSource.Name = "lblSource"
        Me.lblSource.Size = New System.Drawing.Size(986, 37)
        Me.lblSource.TabIndex = 0
        Me.lblSource.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'gbTeams
        '
        Me.tlpMain.SetColumnSpan(Me.gbTeams, 9)
        Me.gbTeams.Controls.Add(Me.tlpTeams)
        Me.gbTeams.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gbTeams.Location = New System.Drawing.Point(259, 130)
        Me.gbTeams.Margin = New System.Windows.Forms.Padding(0)
        Me.gbTeams.Name = "gbTeams"
        Me.gbTeams.Padding = New System.Windows.Forms.Padding(0)
        Me.gbTeams.Size = New System.Drawing.Size(405, 529)
        Me.gbTeams.TabIndex = 2
        Me.gbTeams.TabStop = False
        Me.gbTeams.Text = "Equipos"
        '
        'gbOptions
        '
        Me.tlpMain.SetColumnSpan(Me.gbOptions, 7)
        Me.gbOptions.Controls.Add(Me.tlpOptions)
        Me.gbOptions.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gbOptions.Location = New System.Drawing.Point(674, 130)
        Me.gbOptions.Margin = New System.Windows.Forms.Padding(0)
        Me.gbOptions.Name = "gbOptions"
        Me.gbOptions.Padding = New System.Windows.Forms.Padding(0)
        Me.gbOptions.Size = New System.Drawing.Size(322, 529)
        Me.gbOptions.TabIndex = 3
        Me.gbOptions.TabStop = False
        Me.gbOptions.Text = "Opciones"
        '
        'butClose
        '
        Me.tlpMain.SetColumnSpan(Me.butClose, 3)
        Me.butClose.Dock = System.Windows.Forms.DockStyle.Fill
        Me.butClose.Location = New System.Drawing.Point(840, 669)
        Me.butClose.Margin = New System.Windows.Forms.Padding(0)
        Me.butClose.Name = "butClose"
        Me.butClose.Size = New System.Drawing.Size(156, 50)
        Me.butClose.TabIndex = 4
        Me.butClose.Text = "Cerrar"
        Me.butClose.UseVisualStyleBackColor = True
        '
        'lblMessage
        '
        Me.lblMessage.BackColor = System.Drawing.Color.Transparent
        Me.tlpMain.SetColumnSpan(Me.lblMessage, 23)
        Me.lblMessage.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblMessage.ForeColor = System.Drawing.Color.Red
        Me.lblMessage.Location = New System.Drawing.Point(10, 70)
        Me.lblMessage.Margin = New System.Windows.Forms.Padding(0)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.Size = New System.Drawing.Size(986, 50)
        Me.lblMessage.TabIndex = 5
        Me.lblMessage.Text = "-"
        Me.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tlpTeams
        '
        Me.tlpTeams.BackColor = System.Drawing.Color.Transparent
        Me.tlpTeams.ColumnCount = 5
        Me.tlpTeams.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 5.0!))
        Me.tlpTeams.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpTeams.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 5.0!))
        Me.tlpTeams.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.tlpTeams.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 5.0!))
        Me.tlpTeams.Controls.Add(Me.lvTeams, 1, 1)
        Me.tlpTeams.Controls.Add(Me.lblMove, 3, 1)
        Me.tlpTeams.Controls.Add(Me.butTop, 3, 3)
        Me.tlpTeams.Controls.Add(Me.butUp, 3, 5)
        Me.tlpTeams.Controls.Add(Me.butDown, 3, 7)
        Me.tlpTeams.Controls.Add(Me.butBottom, 3, 9)
        Me.tlpTeams.Controls.Add(Me.lblCount, 1, 13)
        Me.tlpTeams.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpTeams.Location = New System.Drawing.Point(0, 13)
        Me.tlpTeams.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpTeams.Name = "tlpTeams"
        Me.tlpTeams.RowCount = 15
        Me.tlpTeams.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5.0!))
        Me.tlpTeams.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlpTeams.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5.0!))
        Me.tlpTeams.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlpTeams.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5.0!))
        Me.tlpTeams.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlpTeams.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5.0!))
        Me.tlpTeams.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlpTeams.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5.0!))
        Me.tlpTeams.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlpTeams.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5.0!))
        Me.tlpTeams.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpTeams.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5.0!))
        Me.tlpTeams.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlpTeams.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5.0!))
        Me.tlpTeams.Size = New System.Drawing.Size(405, 516)
        Me.tlpTeams.TabIndex = 0
        '
        'lvTeams
        '
        Me.lvTeams.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.chName, Me.chType, Me.chIndex})
        Me.lvTeams.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lvTeams.FullRowSelect = True
        Me.lvTeams.GridLines = True
        Me.lvTeams.HideSelection = False
        Me.lvTeams.Location = New System.Drawing.Point(5, 5)
        Me.lvTeams.Margin = New System.Windows.Forms.Padding(0)
        Me.lvTeams.MultiSelect = False
        Me.lvTeams.Name = "lvTeams"
        Me.tlpTeams.SetRowSpan(Me.lvTeams, 11)
        Me.lvTeams.Size = New System.Drawing.Size(290, 471)
        Me.lvTeams.TabIndex = 0
        Me.lvTeams.UseCompatibleStateImageBehavior = False
        Me.lvTeams.View = System.Windows.Forms.View.Details
        '
        'chName
        '
        Me.chName.Text = "Nombre"
        Me.chName.Width = 120
        '
        'chType
        '
        Me.chType.Text = "Tipo"
        Me.chType.Width = 80
        '
        'tlpOptions
        '
        Me.tlpOptions.BackColor = System.Drawing.Color.Transparent
        Me.tlpOptions.ColumnCount = 5
        Me.tlpOptions.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 5.0!))
        Me.tlpOptions.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpOptions.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 5.0!))
        Me.tlpOptions.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpOptions.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 5.0!))
        Me.tlpOptions.Controls.Add(Me.chkTopLocked, 1, 3)
        Me.tlpOptions.Controls.Add(Me.butSort, 3, 5)
        Me.tlpOptions.Controls.Add(Me.lblSortOptions, 1, 1)
        Me.tlpOptions.Controls.Add(Me.lblSaveOptions, 1, 7)
        Me.tlpOptions.Controls.Add(Me.chkSave, 1, 9)
        Me.tlpOptions.Controls.Add(Me.butSave, 3, 11)
        Me.tlpOptions.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpOptions.Location = New System.Drawing.Point(0, 13)
        Me.tlpOptions.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpOptions.Name = "tlpOptions"
        Me.tlpOptions.RowCount = 15
        Me.tlpOptions.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5.0!))
        Me.tlpOptions.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlpOptions.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5.0!))
        Me.tlpOptions.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlpOptions.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5.0!))
        Me.tlpOptions.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlpOptions.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5.0!))
        Me.tlpOptions.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlpOptions.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5.0!))
        Me.tlpOptions.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlpOptions.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5.0!))
        Me.tlpOptions.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlpOptions.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5.0!))
        Me.tlpOptions.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpOptions.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5.0!))
        Me.tlpOptions.Size = New System.Drawing.Size(322, 516)
        Me.tlpOptions.TabIndex = 0
        '
        'chkTopLocked
        '
        Me.chkTopLocked.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkTopLocked.Checked = True
        Me.chkTopLocked.CheckState = System.Windows.Forms.CheckState.Checked
        Me.tlpOptions.SetColumnSpan(Me.chkTopLocked, 3)
        Me.chkTopLocked.Dock = System.Windows.Forms.DockStyle.Fill
        Me.chkTopLocked.Location = New System.Drawing.Point(5, 40)
        Me.chkTopLocked.Margin = New System.Windows.Forms.Padding(0)
        Me.chkTopLocked.Name = "chkTopLocked"
        Me.chkTopLocked.Size = New System.Drawing.Size(311, 30)
        Me.chkTopLocked.TabIndex = 0
        Me.chkTopLocked.Text = "Colocar grupos fijos al inicio"
        Me.chkTopLocked.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkTopLocked.UseVisualStyleBackColor = True
        '
        'butSort
        '
        Me.butSort.Dock = System.Windows.Forms.DockStyle.Fill
        Me.butSort.Location = New System.Drawing.Point(163, 75)
        Me.butSort.Margin = New System.Windows.Forms.Padding(0)
        Me.butSort.Name = "butSort"
        Me.butSort.Size = New System.Drawing.Size(153, 30)
        Me.butSort.TabIndex = 1
        Me.butSort.Text = "Ordenar"
        Me.butSort.UseVisualStyleBackColor = True
        '
        'lblSortOptions
        '
        Me.tlpOptions.SetColumnSpan(Me.lblSortOptions, 3)
        Me.lblSortOptions.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblSortOptions.ForeColor = System.Drawing.Color.Blue
        Me.lblSortOptions.Location = New System.Drawing.Point(5, 5)
        Me.lblSortOptions.Margin = New System.Windows.Forms.Padding(0)
        Me.lblSortOptions.Name = "lblSortOptions"
        Me.lblSortOptions.Size = New System.Drawing.Size(311, 30)
        Me.lblSortOptions.TabIndex = 2
        Me.lblSortOptions.Text = "Opciones de ordenado"
        Me.lblSortOptions.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblSaveOptions
        '
        Me.tlpOptions.SetColumnSpan(Me.lblSaveOptions, 3)
        Me.lblSaveOptions.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblSaveOptions.ForeColor = System.Drawing.Color.Blue
        Me.lblSaveOptions.Location = New System.Drawing.Point(5, 110)
        Me.lblSaveOptions.Margin = New System.Windows.Forms.Padding(0)
        Me.lblSaveOptions.Name = "lblSaveOptions"
        Me.lblSaveOptions.Size = New System.Drawing.Size(311, 30)
        Me.lblSaveOptions.TabIndex = 3
        Me.lblSaveOptions.Text = "Opciones de guardado"
        Me.lblSaveOptions.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'chkSave
        '
        Me.chkSave.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkSave.Checked = True
        Me.chkSave.CheckState = System.Windows.Forms.CheckState.Checked
        Me.tlpOptions.SetColumnSpan(Me.chkSave, 3)
        Me.chkSave.Dock = System.Windows.Forms.DockStyle.Fill
        Me.chkSave.Location = New System.Drawing.Point(5, 145)
        Me.chkSave.Margin = New System.Windows.Forms.Padding(0)
        Me.chkSave.Name = "chkSave"
        Me.chkSave.Size = New System.Drawing.Size(311, 30)
        Me.chkSave.TabIndex = 4
        Me.chkSave.Text = "Guardar en todas las carpetas"
        Me.chkSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkSave.UseVisualStyleBackColor = True
        '
        'butSave
        '
        Me.butSave.Dock = System.Windows.Forms.DockStyle.Fill
        Me.butSave.Location = New System.Drawing.Point(163, 180)
        Me.butSave.Margin = New System.Windows.Forms.Padding(0)
        Me.butSave.Name = "butSave"
        Me.butSave.Size = New System.Drawing.Size(153, 30)
        Me.butSave.TabIndex = 5
        Me.butSave.Text = "Guardar"
        Me.butSave.UseVisualStyleBackColor = True
        '
        'lblMove
        '
        Me.lblMove.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblMove.ForeColor = System.Drawing.Color.Blue
        Me.lblMove.Location = New System.Drawing.Point(300, 5)
        Me.lblMove.Margin = New System.Windows.Forms.Padding(0)
        Me.lblMove.Name = "lblMove"
        Me.lblMove.Size = New System.Drawing.Size(100, 30)
        Me.lblMove.TabIndex = 1
        Me.lblMove.Text = "Mover a"
        Me.lblMove.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'butTop
        '
        Me.butTop.Dock = System.Windows.Forms.DockStyle.Fill
        Me.butTop.Location = New System.Drawing.Point(300, 40)
        Me.butTop.Margin = New System.Windows.Forms.Padding(0)
        Me.butTop.Name = "butTop"
        Me.butTop.Size = New System.Drawing.Size(100, 30)
        Me.butTop.TabIndex = 2
        Me.butTop.Text = "Inicio"
        Me.butTop.UseVisualStyleBackColor = True
        '
        'butUp
        '
        Me.butUp.Dock = System.Windows.Forms.DockStyle.Fill
        Me.butUp.Location = New System.Drawing.Point(300, 75)
        Me.butUp.Margin = New System.Windows.Forms.Padding(0)
        Me.butUp.Name = "butUp"
        Me.butUp.Size = New System.Drawing.Size(100, 30)
        Me.butUp.TabIndex = 3
        Me.butUp.Text = "Arriba"
        Me.butUp.UseVisualStyleBackColor = True
        '
        'butDown
        '
        Me.butDown.Dock = System.Windows.Forms.DockStyle.Fill
        Me.butDown.Location = New System.Drawing.Point(300, 110)
        Me.butDown.Margin = New System.Windows.Forms.Padding(0)
        Me.butDown.Name = "butDown"
        Me.butDown.Size = New System.Drawing.Size(100, 30)
        Me.butDown.TabIndex = 4
        Me.butDown.Text = "Abajo"
        Me.butDown.UseVisualStyleBackColor = True
        '
        'butBottom
        '
        Me.butBottom.Dock = System.Windows.Forms.DockStyle.Fill
        Me.butBottom.Location = New System.Drawing.Point(300, 145)
        Me.butBottom.Margin = New System.Windows.Forms.Padding(0)
        Me.butBottom.Name = "butBottom"
        Me.butBottom.Size = New System.Drawing.Size(100, 30)
        Me.butBottom.TabIndex = 5
        Me.butBottom.Text = "Ultimo"
        Me.butBottom.UseVisualStyleBackColor = True
        '
        'lblCount
        '
        Me.tlpTeams.SetColumnSpan(Me.lblCount, 3)
        Me.lblCount.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblCount.ForeColor = System.Drawing.Color.Blue
        Me.lblCount.Location = New System.Drawing.Point(5, 481)
        Me.lblCount.Margin = New System.Windows.Forms.Padding(0)
        Me.lblCount.Name = "lblCount"
        Me.lblCount.Size = New System.Drawing.Size(395, 30)
        Me.lblCount.TabIndex = 6
        Me.lblCount.Text = "Ningun equipo cargado"
        Me.lblCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'chIndex
        '
        Me.chIndex.Text = "Indice"
        Me.chIndex.Width = 50
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 729)
        Me.Controls.Add(Me.tlpMain)
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PetBattleTeams Sorter"
        Me.tlpMain.ResumeLayout(False)
        Me.gbDetect.ResumeLayout(False)
        Me.tlpDetect.ResumeLayout(False)
        Me.gbSource.ResumeLayout(False)
        Me.gbTeams.ResumeLayout(False)
        Me.gbOptions.ResumeLayout(False)
        Me.tlpTeams.ResumeLayout(False)
        Me.tlpOptions.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tlpMain As TableLayoutPanel
    Friend WithEvents gbDetect As GroupBox
    Friend WithEvents tlpDetect As TableLayoutPanel
    Friend WithEvents butDetect As Button
    Friend WithEvents butLoad As Button
    Friend WithEvents lvFolders As ListView
    Friend WithEvents chFolder As ColumnHeader
    Friend WithEvents gbSource As GroupBox
    Friend WithEvents lblSource As Label
    Friend WithEvents gbTeams As GroupBox
    Friend WithEvents gbOptions As GroupBox
    Friend WithEvents butClose As Button
    Friend WithEvents lblMessage As Label
    Friend WithEvents tlpTeams As TableLayoutPanel
    Friend WithEvents lvTeams As ListView
    Friend WithEvents chName As ColumnHeader
    Friend WithEvents chType As ColumnHeader
    Friend WithEvents tlpOptions As TableLayoutPanel
    Friend WithEvents chkTopLocked As CheckBox
    Friend WithEvents butSort As Button
    Friend WithEvents lblMove As Label
    Friend WithEvents butTop As Button
    Friend WithEvents butUp As Button
    Friend WithEvents butDown As Button
    Friend WithEvents butBottom As Button
    Friend WithEvents lblSortOptions As Label
    Friend WithEvents lblSaveOptions As Label
    Friend WithEvents chkSave As CheckBox
    Friend WithEvents butSave As Button
    Friend WithEvents lblCount As Label
    Friend WithEvents chIndex As ColumnHeader
End Class

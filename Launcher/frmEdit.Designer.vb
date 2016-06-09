<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEdit
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEdit))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.cmdFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdLogin = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.UsernameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PasswordDataGridView = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UserTypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.USERINFOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DbDataSet = New Launcher.dbDataSet()
        Me.USERINFOTableAdapter = New Launcher.dbDataSetTableAdapters.USERINFOTableAdapter()
        Me.BindingNavigator1 = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.cmdAddNew = New System.Windows.Forms.ToolStripButton()
        Me.lblCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.cmdDelete = New System.Windows.Forms.ToolStripButton()
        Me.cmdMoveFirst = New System.Windows.Forms.ToolStripButton()
        Me.cmdPrevious = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.txtPosition = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdNext = New System.Windows.Forms.ToolStripButton()
        Me.cmdLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdNew = New System.Windows.Forms.ToolStripButton()
        Me.cmdOpen = New System.Windows.Forms.ToolStripButton()
        Me.cmdSave = New System.Windows.Forms.ToolStripButton()
        Me.cmdPrint = New System.Windows.Forms.ToolStripButton()
        Me.toolStripSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdCut = New System.Windows.Forms.ToolStripButton()
        Me.cmdCopy = New System.Windows.Forms.ToolStripButton()
        Me.cmdPaste = New System.Windows.Forms.ToolStripButton()
        Me.toolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdHelp = New System.Windows.Forms.ToolStripButton()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.USERINFOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DbDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdFile})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(972, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'cmdFile
        '
        Me.cmdFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdExit, Me.cmdLogin})
        Me.cmdFile.Name = "cmdFile"
        Me.cmdFile.Size = New System.Drawing.Size(37, 20)
        Me.cmdFile.Text = "File"
        '
        'cmdExit
        '
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(180, 22)
        Me.cmdExit.Text = "Exit"
        '
        'cmdLogin
        '
        Me.cmdLogin.Name = "cmdLogin"
        Me.cmdLogin.Size = New System.Drawing.Size(180, 22)
        Me.cmdLogin.Text = "Back to login screen"
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.UsernameDataGridViewTextBoxColumn, Me.PasswordDataGridView, Me.UserTypeDataGridViewTextBoxColumn, Me.UIDDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.USERINFOBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(0, 52)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(972, 424)
        Me.DataGridView1.TabIndex = 1
        '
        'UsernameDataGridViewTextBoxColumn
        '
        Me.UsernameDataGridViewTextBoxColumn.DataPropertyName = "Username"
        Me.UsernameDataGridViewTextBoxColumn.HeaderText = "Username"
        Me.UsernameDataGridViewTextBoxColumn.Name = "UsernameDataGridViewTextBoxColumn"
        '
        'PasswordDataGridView
        '
        Me.PasswordDataGridView.DataPropertyName = "Password"
        Me.PasswordDataGridView.HeaderText = "Password"
        Me.PasswordDataGridView.Name = "PasswordDataGridView"
        '
        'UserTypeDataGridViewTextBoxColumn
        '
        Me.UserTypeDataGridViewTextBoxColumn.DataPropertyName = "UserType"
        Me.UserTypeDataGridViewTextBoxColumn.HeaderText = "UserType"
        Me.UserTypeDataGridViewTextBoxColumn.Name = "UserTypeDataGridViewTextBoxColumn"
        '
        'UIDDataGridViewTextBoxColumn
        '
        Me.UIDDataGridViewTextBoxColumn.DataPropertyName = "UID"
        Me.UIDDataGridViewTextBoxColumn.HeaderText = "UID"
        Me.UIDDataGridViewTextBoxColumn.Name = "UIDDataGridViewTextBoxColumn"
        '
        'USERINFOBindingSource
        '
        Me.USERINFOBindingSource.DataMember = "USERINFO"
        Me.USERINFOBindingSource.DataSource = Me.DbDataSet
        '
        'DbDataSet
        '
        Me.DbDataSet.DataSetName = "dbDataSet"
        Me.DbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'USERINFOTableAdapter
        '
        Me.USERINFOTableAdapter.ClearBeforeFill = True
        '
        'BindingNavigator1
        '
        Me.BindingNavigator1.AddNewItem = Me.cmdAddNew
        Me.BindingNavigator1.CountItem = Me.lblCountItem
        Me.BindingNavigator1.DeleteItem = Me.cmdDelete
        Me.BindingNavigator1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdMoveFirst, Me.cmdPrevious, Me.BindingNavigatorSeparator, Me.txtPosition, Me.lblCountItem, Me.BindingNavigatorSeparator1, Me.cmdNext, Me.cmdLastItem, Me.BindingNavigatorSeparator2, Me.cmdAddNew, Me.cmdDelete, Me.cmdNew, Me.cmdOpen, Me.cmdSave, Me.cmdPrint, Me.toolStripSeparator, Me.cmdCut, Me.cmdCopy, Me.cmdPaste, Me.toolStripSeparator1, Me.cmdHelp})
        Me.BindingNavigator1.Location = New System.Drawing.Point(0, 24)
        Me.BindingNavigator1.MoveFirstItem = Me.cmdMoveFirst
        Me.BindingNavigator1.MoveLastItem = Me.cmdLastItem
        Me.BindingNavigator1.MoveNextItem = Me.cmdNext
        Me.BindingNavigator1.MovePreviousItem = Me.cmdPrevious
        Me.BindingNavigator1.Name = "BindingNavigator1"
        Me.BindingNavigator1.PositionItem = Me.txtPosition
        Me.BindingNavigator1.Size = New System.Drawing.Size(972, 25)
        Me.BindingNavigator1.TabIndex = 2
        Me.BindingNavigator1.Text = "BindingNavigator1"
        '
        'cmdAddNew
        '
        Me.cmdAddNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdAddNew.Image = CType(resources.GetObject("cmdAddNew.Image"), System.Drawing.Image)
        Me.cmdAddNew.Name = "cmdAddNew"
        Me.cmdAddNew.RightToLeftAutoMirrorImage = True
        Me.cmdAddNew.Size = New System.Drawing.Size(23, 22)
        Me.cmdAddNew.Text = "Add new"
        '
        'lblCountItem
        '
        Me.lblCountItem.Name = "lblCountItem"
        Me.lblCountItem.Size = New System.Drawing.Size(35, 22)
        Me.lblCountItem.Text = "of {0}"
        Me.lblCountItem.ToolTipText = "Total number of items"
        '
        'cmdDelete
        '
        Me.cmdDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdDelete.Image = CType(resources.GetObject("cmdDelete.Image"), System.Drawing.Image)
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.RightToLeftAutoMirrorImage = True
        Me.cmdDelete.Size = New System.Drawing.Size(23, 22)
        Me.cmdDelete.Text = "Delete"
        '
        'cmdMoveFirst
        '
        Me.cmdMoveFirst.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdMoveFirst.Image = CType(resources.GetObject("cmdMoveFirst.Image"), System.Drawing.Image)
        Me.cmdMoveFirst.Name = "cmdMoveFirst"
        Me.cmdMoveFirst.RightToLeftAutoMirrorImage = True
        Me.cmdMoveFirst.Size = New System.Drawing.Size(23, 22)
        Me.cmdMoveFirst.Text = "Move first"
        '
        'cmdPrevious
        '
        Me.cmdPrevious.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdPrevious.Image = CType(resources.GetObject("cmdPrevious.Image"), System.Drawing.Image)
        Me.cmdPrevious.Name = "cmdPrevious"
        Me.cmdPrevious.RightToLeftAutoMirrorImage = True
        Me.cmdPrevious.Size = New System.Drawing.Size(23, 22)
        Me.cmdPrevious.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'txtPosition
        '
        Me.txtPosition.AccessibleName = "Position"
        Me.txtPosition.AutoSize = False
        Me.txtPosition.Name = "txtPosition"
        Me.txtPosition.Size = New System.Drawing.Size(50, 23)
        Me.txtPosition.Text = "0"
        Me.txtPosition.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'cmdNext
        '
        Me.cmdNext.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdNext.Image = CType(resources.GetObject("cmdNext.Image"), System.Drawing.Image)
        Me.cmdNext.Name = "cmdNext"
        Me.cmdNext.RightToLeftAutoMirrorImage = True
        Me.cmdNext.Size = New System.Drawing.Size(23, 22)
        Me.cmdNext.Text = "Move next"
        '
        'cmdLastItem
        '
        Me.cmdLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdLastItem.Image = CType(resources.GetObject("cmdLastItem.Image"), System.Drawing.Image)
        Me.cmdLastItem.Name = "cmdLastItem"
        Me.cmdLastItem.RightToLeftAutoMirrorImage = True
        Me.cmdLastItem.Size = New System.Drawing.Size(23, 22)
        Me.cmdLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'cmdNew
        '
        Me.cmdNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdNew.Image = CType(resources.GetObject("cmdNew.Image"), System.Drawing.Image)
        Me.cmdNew.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdNew.Name = "cmdNew"
        Me.cmdNew.Size = New System.Drawing.Size(23, 22)
        Me.cmdNew.Text = "&New"
        '
        'cmdOpen
        '
        Me.cmdOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdOpen.Image = CType(resources.GetObject("cmdOpen.Image"), System.Drawing.Image)
        Me.cmdOpen.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdOpen.Name = "cmdOpen"
        Me.cmdOpen.Size = New System.Drawing.Size(23, 22)
        Me.cmdOpen.Text = "&Open"
        '
        'cmdSave
        '
        Me.cmdSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdSave.Image = CType(resources.GetObject("cmdSave.Image"), System.Drawing.Image)
        Me.cmdSave.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(23, 22)
        Me.cmdSave.Text = "&Save"
        '
        'cmdPrint
        '
        Me.cmdPrint.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdPrint.Image = CType(resources.GetObject("cmdPrint.Image"), System.Drawing.Image)
        Me.cmdPrint.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdPrint.Name = "cmdPrint"
        Me.cmdPrint.Size = New System.Drawing.Size(23, 22)
        Me.cmdPrint.Text = "&Print"
        '
        'toolStripSeparator
        '
        Me.toolStripSeparator.Name = "toolStripSeparator"
        Me.toolStripSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'cmdCut
        '
        Me.cmdCut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdCut.Image = CType(resources.GetObject("cmdCut.Image"), System.Drawing.Image)
        Me.cmdCut.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdCut.Name = "cmdCut"
        Me.cmdCut.Size = New System.Drawing.Size(23, 22)
        Me.cmdCut.Text = "C&ut"
        '
        'cmdCopy
        '
        Me.cmdCopy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdCopy.Image = CType(resources.GetObject("cmdCopy.Image"), System.Drawing.Image)
        Me.cmdCopy.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdCopy.Name = "cmdCopy"
        Me.cmdCopy.Size = New System.Drawing.Size(23, 22)
        Me.cmdCopy.Text = "&Copy"
        '
        'cmdPaste
        '
        Me.cmdPaste.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdPaste.Image = CType(resources.GetObject("cmdPaste.Image"), System.Drawing.Image)
        Me.cmdPaste.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdPaste.Name = "cmdPaste"
        Me.cmdPaste.Size = New System.Drawing.Size(23, 22)
        Me.cmdPaste.Text = "&Paste"
        '
        'toolStripSeparator1
        '
        Me.toolStripSeparator1.Name = "toolStripSeparator1"
        Me.toolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'cmdHelp
        '
        Me.cmdHelp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdHelp.Image = CType(resources.GetObject("cmdHelp.Image"), System.Drawing.Image)
        Me.cmdHelp.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdHelp.Name = "cmdHelp"
        Me.cmdHelp.Size = New System.Drawing.Size(23, 22)
        Me.cmdHelp.Text = "He&lp"
        '
        'frmEdit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(972, 477)
        Me.Controls.Add(Me.BindingNavigator1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmEdit"
        Me.Text = "Edit user data"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.USERINFOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DbDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator1.ResumeLayout(False)
        Me.BindingNavigator1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents DbDataSet As Launcher.dbDataSet
    Friend WithEvents USERINFOBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents USERINFOTableAdapter As Launcher.dbDataSetTableAdapters.USERINFOTableAdapter
    Friend WithEvents UsernameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PasswordDataGridView As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UserTypeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BindingNavigator1 As System.Windows.Forms.BindingNavigator
    Friend WithEvents cmdAddNew As System.Windows.Forms.ToolStripButton
    Friend WithEvents lblCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents cmdDelete As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdMoveFirst As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdPrevious As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents txtPosition As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmdNext As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmdNew As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdOpen As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdSave As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdPrint As System.Windows.Forms.ToolStripButton
    Friend WithEvents toolStripSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmdCut As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdCopy As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdPaste As System.Windows.Forms.ToolStripButton
    Friend WithEvents toolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmdHelp As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdFile As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdExit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdLogin As System.Windows.Forms.ToolStripMenuItem
End Class

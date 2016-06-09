<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.mainMenu = New System.Windows.Forms.MenuStrip()
        Me.cmdFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdEdit = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdColors = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdBackground = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdText = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdLogin = New System.Windows.Forms.Button()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.DbDataSet = New Launcher.dbDataSet()
        Me.dbBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.dbTableAdapter = New Launcher.dbDataSetTableAdapters.USERINFOTableAdapter()
        Me.TableAdapterManager = New Launcher.dbDataSetTableAdapters.TableAdapterManager()
        Me.cmdCreate = New System.Windows.Forms.Button()
        Me.mainMenu.SuspendLayout()
        CType(Me.DbDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dbBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'mainMenu
        '
        Me.mainMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdFile, Me.cmdEdit})
        Me.mainMenu.Location = New System.Drawing.Point(0, 0)
        Me.mainMenu.Name = "mainMenu"
        Me.mainMenu.Size = New System.Drawing.Size(333, 24)
        Me.mainMenu.TabIndex = 0
        Me.mainMenu.Text = "Main Menu Strip"
        '
        'cmdFile
        '
        Me.cmdFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdExit})
        Me.cmdFile.Name = "cmdFile"
        Me.cmdFile.Size = New System.Drawing.Size(37, 20)
        Me.cmdFile.Text = "File"
        '
        'cmdExit
        '
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(92, 22)
        Me.cmdExit.Text = "Exit"
        '
        'cmdEdit
        '
        Me.cmdEdit.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdColors})
        Me.cmdEdit.Name = "cmdEdit"
        Me.cmdEdit.Size = New System.Drawing.Size(39, 20)
        Me.cmdEdit.Text = "Edit"
        '
        'cmdColors
        '
        Me.cmdColors.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdBackground, Me.cmdText})
        Me.cmdColors.Name = "cmdColors"
        Me.cmdColors.Size = New System.Drawing.Size(108, 22)
        Me.cmdColors.Text = "Colors"
        '
        'cmdBackground
        '
        Me.cmdBackground.Name = "cmdBackground"
        Me.cmdBackground.Size = New System.Drawing.Size(138, 22)
        Me.cmdBackground.Text = "Background"
        '
        'cmdText
        '
        Me.cmdText.Name = "cmdText"
        Me.cmdText.Size = New System.Drawing.Size(138, 22)
        Me.cmdText.Text = "Text"
        '
        'cmdLogin
        '
        Me.cmdLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdLogin.Location = New System.Drawing.Point(242, 27)
        Me.cmdLogin.Name = "cmdLogin"
        Me.cmdLogin.Size = New System.Drawing.Size(80, 80)
        Me.cmdLogin.TabIndex = 1
        Me.cmdLogin.Text = "Login"
        Me.cmdLogin.UseVisualStyleBackColor = True
        '
        'txtUsername
        '
        Me.txtUsername.Location = New System.Drawing.Point(12, 43)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(224, 20)
        Me.txtUsername.TabIndex = 2
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(12, 82)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(224, 20)
        Me.txtPassword.TabIndex = 3
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Location = New System.Drawing.Point(9, 66)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(56, 13)
        Me.lblPassword.TabIndex = 4
        Me.lblPassword.Text = "Password:"
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.Location = New System.Drawing.Point(9, 27)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(58, 13)
        Me.lblUsername.TabIndex = 5
        Me.lblUsername.Text = "Username:"
        '
        'DbDataSet
        '
        Me.DbDataSet.DataSetName = "dbDataSet"
        Me.DbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'dbBindingSource
        '
        Me.dbBindingSource.DataMember = "USERINFO"
        Me.dbBindingSource.DataSource = Me.DbDataSet
        '
        'dbTableAdapter
        '
        Me.dbTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.UpdateOrder = Launcher.dbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.USERINFOTableAdapter = Me.dbTableAdapter
        '
        'cmdCreate
        '
        Me.cmdCreate.Location = New System.Drawing.Point(12, 115)
        Me.cmdCreate.Name = "cmdCreate"
        Me.cmdCreate.Size = New System.Drawing.Size(309, 23)
        Me.cmdCreate.TabIndex = 6
        Me.cmdCreate.Text = "Create an account"
        Me.cmdCreate.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(333, 150)
        Me.Controls.Add(Me.cmdCreate)
        Me.Controls.Add(Me.lblUsername)
        Me.Controls.Add(Me.lblPassword)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.cmdLogin)
        Me.Controls.Add(Me.mainMenu)
        Me.MainMenuStrip = Me.mainMenu
        Me.Name = "frmMain"
        Me.Text = "Login"
        Me.mainMenu.ResumeLayout(False)
        Me.mainMenu.PerformLayout()
        CType(Me.DbDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dbBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents mainMenu As System.Windows.Forms.MenuStrip
    Friend WithEvents cmdFile As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdExit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdEdit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdColors As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdBackground As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdText As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdLogin As System.Windows.Forms.Button
    Friend WithEvents txtUsername As System.Windows.Forms.TextBox
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents lblPassword As System.Windows.Forms.Label
    Friend WithEvents lblUsername As System.Windows.Forms.Label
    Friend WithEvents DbDataSet As Launcher.dbDataSet
    Friend WithEvents dbBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents dbTableAdapter As Launcher.dbDataSetTableAdapters.USERINFOTableAdapter
    Friend WithEvents TableAdapterManager As Launcher.dbDataSetTableAdapters.TableAdapterManager
    Friend WithEvents cmdCreate As System.Windows.Forms.Button

End Class

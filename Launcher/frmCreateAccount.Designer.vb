<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCreateAccount
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
        Dim lblUsername As System.Windows.Forms.Label
        Dim lblPassword As System.Windows.Forms.Label
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.USERINFOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DbDataSet = New Launcher.dbDataSet()
        Me.TableAdapterManager = New Launcher.dbDataSetTableAdapters.TableAdapterManager()
        Me.USERINFOTableAdapter = New Launcher.dbDataSetTableAdapters.USERINFOTableAdapter()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        lblUsername = New System.Windows.Forms.Label()
        lblPassword = New System.Windows.Forms.Label()
        CType(Me.USERINFOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DbDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblUsername
        '
        lblUsername.AutoSize = True
        lblUsername.Location = New System.Drawing.Point(14, 15)
        lblUsername.Name = "lblUsername"
        lblUsername.Size = New System.Drawing.Size(58, 13)
        lblUsername.TabIndex = 8
        lblUsername.Text = "Username:"
        '
        'lblPassword
        '
        lblPassword.AutoSize = True
        lblPassword.Location = New System.Drawing.Point(16, 44)
        lblPassword.Name = "lblPassword"
        lblPassword.Size = New System.Drawing.Size(56, 13)
        lblPassword.TabIndex = 10
        lblPassword.Text = "Password:"
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OK_Button.Location = New System.Drawing.Point(7, 68)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(93, 23)
        Me.OK_Button.TabIndex = 12
        Me.OK_Button.Text = "Create Account"
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
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.UpdateOrder = Launcher.dbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.USERINFOTableAdapter = Me.USERINFOTableAdapter
        '
        'USERINFOTableAdapter
        '
        Me.USERINFOTableAdapter.ClearBeforeFill = True
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Location = New System.Drawing.Point(119, 68)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(67, 23)
        Me.Cancel_Button.TabIndex = 13
        Me.Cancel_Button.Text = "Cancel"
        '
        'txtUsername
        '
        Me.txtUsername.Location = New System.Drawing.Point(78, 12)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(100, 20)
        Me.txtUsername.TabIndex = 14
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(78, 44)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(100, 20)
        Me.txtPassword.TabIndex = 15
        '
        'frmCreateAccount
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(192, 104)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.OK_Button)
        Me.Controls.Add(lblUsername)
        Me.Controls.Add(lblPassword)
        Me.Controls.Add(Me.Cancel_Button)
        Me.Name = "frmCreateAccount"
        Me.Text = "frmCreateAccount"
        CType(Me.USERINFOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DbDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents USERINFOBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DbDataSet As Launcher.dbDataSet
    Friend WithEvents TableAdapterManager As Launcher.dbDataSetTableAdapters.TableAdapterManager
    Friend WithEvents USERINFOTableAdapter As Launcher.dbDataSetTableAdapters.USERINFOTableAdapter
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents txtUsername As System.Windows.Forms.TextBox
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
End Class

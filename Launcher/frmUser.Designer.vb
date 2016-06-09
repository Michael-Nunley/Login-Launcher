<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUser
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
        Me.cmdExit = New System.Windows.Forms.Button()
        Me.cmdTest = New System.Windows.Forms.Button()
        Me.cmdGenerate = New System.Windows.Forms.Button()
        Me.tmrRandom = New System.Windows.Forms.Timer(Me.components)
        Me.cmdTell = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'cmdExit
        '
        Me.cmdExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdExit.Location = New System.Drawing.Point(12, 12)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(166, 147)
        Me.cmdExit.TabIndex = 0
        Me.cmdExit.Text = "Exit"
        Me.cmdExit.UseVisualStyleBackColor = True
        '
        'cmdTest
        '
        Me.cmdTest.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdTest.Location = New System.Drawing.Point(184, 12)
        Me.cmdTest.Name = "cmdTest"
        Me.cmdTest.Size = New System.Drawing.Size(166, 147)
        Me.cmdTest.TabIndex = 1
        Me.cmdTest.Text = "test"
        Me.cmdTest.UseVisualStyleBackColor = True
        '
        'cmdGenerate
        '
        Me.cmdGenerate.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdGenerate.Location = New System.Drawing.Point(356, 12)
        Me.cmdGenerate.Name = "cmdGenerate"
        Me.cmdGenerate.Size = New System.Drawing.Size(166, 147)
        Me.cmdGenerate.TabIndex = 2
        Me.cmdGenerate.Text = "false"
        Me.cmdGenerate.UseVisualStyleBackColor = True
        '
        'tmrRandom
        '
        Me.tmrRandom.Interval = 1
        '
        'cmdTell
        '
        Me.cmdTell.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdTell.Location = New System.Drawing.Point(528, 12)
        Me.cmdTell.Name = "cmdTell"
        Me.cmdTell.Size = New System.Drawing.Size(166, 147)
        Me.cmdTell.TabIndex = 3
        Me.cmdTell.Text = "Tell me"
        Me.cmdTell.UseVisualStyleBackColor = True
        '
        'frmUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(808, 189)
        Me.Controls.Add(Me.cmdTell)
        Me.Controls.Add(Me.cmdGenerate)
        Me.Controls.Add(Me.cmdTest)
        Me.Controls.Add(Me.cmdExit)
        Me.Name = "frmUser"
        Me.Text = "User Screen"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmdExit As System.Windows.Forms.Button
    Friend WithEvents cmdTest As System.Windows.Forms.Button
    Friend WithEvents cmdGenerate As System.Windows.Forms.Button
    Friend WithEvents tmrRandom As System.Windows.Forms.Timer
    Friend WithEvents cmdTell As System.Windows.Forms.Button
End Class

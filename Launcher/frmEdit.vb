Public Class frmEdit
    Private Sub frmEdit_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'loads data into the database table.
        Me.USERINFOTableAdapter.Fill(Me.DbDataSet.USERINFO)
    End Sub
    Private Sub SaveToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        'Validates, or saves, the data.
        If Me.Validate() Then
            Me.USERINFOBindingSource.EndEdit()
            Me.USERINFOTableAdapter.Update(Me.DbDataSet)
        Else
            MsgBox("Validation errors.")
        End If
    End Sub
    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        frmLogin.Close()
        frmUser.Close()
        frmCreateAccount.Close()
        Me.Close()
    End Sub
    Private Sub cmdLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdLogin.Click
        frmLogin.Visible = True
        Me.Close()
    End Sub
End Class
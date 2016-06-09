Imports System.Windows.Forms
Public Class CreateAccount
    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Dim username As String = UsernameTextBox.Text
        Dim password As String = PasswordTextBox.Text
        If username <> "" AndAlso password <> "" Then
            username = UsernameTextBox.Text
            password = PasswordTextBox.Text
            Me.DbDataSet.USERINFO.AddUSERINFORow(username, password, "User", Guid.NewGuid())
        Else
            MsgBox("Username/ password can not be left empty.")
            Return
        End If
        Try
            Me.Validate()
            Me.USERINFOBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.DbDataSet)
            Me.Close()
        Catch ex As Exception
            PasswordTextBox.Text = vbNullString
            username = vbNullString
            password = vbNullString
            UsernameTextBox.Text = vbNullString
            MsgBox("Username in use, Please use a different username.")
        End Try
    End Sub
    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub
    Private Sub CreateAccount_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        PasswordTextBox.Text = vbNullString
        UsernameTextBox.Text = vbNullString
        Me.USERINFOTableAdapter.Fill(Me.DbDataSet.USERINFO)
    End Sub
    Private Sub CreateAccount_Load2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Shown
        PasswordTextBox.Text = vbNullString
        UsernameTextBox.Text = vbNullString
        Me.USERINFOTableAdapter.Fill(Me.DbDataSet.USERINFO)
    End Sub
End Class

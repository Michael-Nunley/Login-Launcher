Public Class frmCreateAccount
    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Dim username As String = txtUsername.Text
        Dim password As String = txtPassword.Text
        'checks if the username and password are not empty
        If username <> "" AndAlso password <> "" Then

            username = txtUsername.Text

            password = txtPassword.Text
            'makes a new account with the imputed information
            Dim newRow As DataRow = DbDataSet.USERINFO.NewRow()

            newRow(0) = username

            newRow(1) = password

            '==============================================================================================================
            'Edit the line below to change the default user type.
            newRow(2) = "User"
            '==============================================================================================================

            'generates a new Unique Identifier. 99.999% of the time it will be completely unqiue.
            newRow(3) = Guid.NewGuid()
            DbDataSet.USERINFO.Rows.Add(newRow)
        Else
            MsgBox("Username/ password can not be left empty.")
            Return
        End If
        Try
            'saves the information to the database
            Me.Validate()
            Me.USERINFOBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.DbDataSet)
            'clears the information in the boxes.
            txtPassword.Text = vbNullString
            username = vbNullString
            password = vbNullString
            txtUsername.Text = vbNullString
            Me.Close()
        Catch ex As Exception
            'Username is in use.
            txtPassword.Text = vbNullString
            username = vbNullString
            password = vbNullString
            txtUsername.Text = vbNullString
            MsgBox("Username in use, Please use a different username.")
        End Try
    End Sub
    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.Close()
    End Sub
    Private Sub CreateAccount_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.VisibleChanged, Me.Load, Me.Shown
        txtPassword.Text = ""
        txtUsername.Text = vbNullString
        Me.USERINFOTableAdapter.Fill(Me.DbDataSet.USERINFO)
    End Sub
End Class
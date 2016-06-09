Public Class frmMain
    Dim inputedUsername As String
    Dim inputedPassword As String
    Private Sub cmdLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdLogin.Click
        inputedUsername = txtUsername.Text
        inputedPassword = txtPassword.Text
        Try
            If checkLogin() = 0 Then
                MsgBox("Username or Password are not correct.")
            ElseIf checkLogin() = 1 Then
                MsgBox("Password not correct.")
            ElseIf checkLogin() = 2 Then
                MsgBox("User login Successful")
                Me.Visible = False
                frmUser.Visible = True
            ElseIf checkLogin() = 3 Then
                MsgBox("Admin login Successful")
                Me.Visible = False
                frmEdit.Visible = True
            End If
        Catch ex As Exception
            MsgBox("Database is empty")
        End Try
    End Sub
    Public Function checkLogin() As Byte
        Dim dbPos As Integer = 0
        Dim isLogin As Byte = 255
        Dim selectedUsername As String
        Dim selectedPassword As String
        Me.dbTableAdapter.Fill(Me.DbDataSet.USERINFO)
        While isLogin = 255
            selectedUsername = dbDataSet.USERINFO(dbPos).Username.Trim()
            selectedPassword = DbDataSet.USERINFO(dbPos).Password.Trim()
            If inputedUsername = selectedUsername Then
                If inputedPassword = selectedPassword Then
                    If DbDataSet.USERINFO(dbPos).UserType = "User" Then
                        isLogin = 2
                    ElseIf DbDataSet.USERINFO(dbPos).UserType = "Admin" Then
                        isLogin = 3
                    End If
                Else
                    isLogin = 1
                End If
            Else
                If dbPos >= 99 Then
                    isLogin = 0
                Else
                    dbPos += 1
                End If
            End If
        End While
        Return isLogin
    End Function
    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub
    Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DbDataSet.USERINFO' table. You can move, or remove it, as needed.
        Me.dbTableAdapter.Fill(Me.DbDataSet.USERINFO)
        If DbDataSet.USERINFO(0).UID <> Guid.Empty Then
            'Dim newRow As DataRow = DbDataSet.USERINFO.NewRow()
            ' newRow(0) = "Admin"
            ''newRow(1) = "Password123"
            'newRow(2) = "Admin"
            'newRow(3) = Guid.Empty
            'DbDataSet.USERINFO.Rows.Add(newRow)
            Me.DbDataSet.USERINFO.AddUSERINFORow("Admin", "Password123", "Admin", Guid.Empty)
            Me.Validate()
            Me.USERINFOBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.DbDataSet)
        End If
    End Sub
    Private Sub cmdCreate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCreate.Click
        frmCreateAccount.Visible = True
    End Sub
End Class

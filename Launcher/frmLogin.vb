'============================================================================
'This is where the majority of the login guts are.
'Once you change the form that the user sees, 
'add a function/sub to that form that includes something that deals with

'frmLogin.DbDataSet.USERINFO(frmLogin.dbPos).UID

'or

'frmLogin.DbDataSet.USERINFO(frmLogin.dbPos).Username

'This is what will link the username to the user data that you may store.
'============================================================================
Public Class frmLogin

    Public dbPos As Integer = 0
    Dim inputedUsername As String
    Dim inputedPassword As String

    Private Sub cmdLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdLogin.Click
        inputedUsername = txtUsername.Text
        inputedPassword = txtPassword.Text
        Try

            'If the function returns 0 then the username and password are wrong.

            If checkLogin() = 0 Then
                MsgBox("Username or Password are not correct.")

            ElseIf checkLogin() = 1 Then
                'and if the function returns 1 then the password is wrong.
                MsgBox("Password not correct.")

            ElseIf checkLogin() = 2 Then
                'and if the function returns 2, then person who is loggin in is a user, so show them the user form
                MsgBox("User login Successful")

                Me.Visible = False

                '===========================================================================================
                'CHANGE frmUser.visible = true to what ever the user form you want to be opend for users.
                frmUser.Visible = True
                '===========================================================================================

            ElseIf checkLogin() = 3 Then
                'and if the function returns 3, then the person who is logging in is an admin, so show them the admin form (frmedit).
                MsgBox("Admin login Successful")
                Me.Visible = False
                '================================================================================
                'Change this to what ever form you would like your administrators to see.
                'I recommend you do not change this.
                frmEdit.Visible = True
                '================================================================================



                '=====================================================================================================
                'Add another Else if statement like above to match the appropriate usertype should you add a new one.
                'See below in checkLogin()
                '======================================================================================================
            End If
        Catch ex As Exception

            'Usually the database is empty,
            'However it can actually not be empty but this message is to cover the majority of cases.
            MsgBox("Database is empty")
        End Try
    End Sub

    Public Function checkLogin() As Byte

        dbPos = 0
        Dim isLogin As Byte = 255
        Dim selectedUsername As String
        Dim selectedPassword As String
        Me.dbTableAdapter.Fill(Me.DbDataSet.USERINFO)
        'Defaults to 255, will end the checklogin once it is set to a value other than 255.

        While isLogin = 255

            selectedUsername = DbDataSet.USERINFO(dbPos).Username.Trim()

            selectedPassword = DbDataSet.USERINFO(dbPos).Password.Trim()

            'if the user user imputed is in the database
            If inputedUsername = selectedUsername Then

                'If the user inputed password is correct to the selected username
                If inputedPassword = selectedPassword Then
                    'if the user type is either an admin or a user

                    If DbDataSet.USERINFO(dbPos).UserType = "User" Then
                        'set the function's value to 2, refer to the cmdLogin sub
                        isLogin = 2

                    ElseIf DbDataSet.USERINFO(dbPos).UserType = "Admin" Then

                        'set the function's value to 3, refer to the cmdLogin sub
                        isLogin = 3
                        '=============================================
                        'if you add another elseif like the one above, 
                        'you can create another user type,
                        'such as a moderator, teacher, or guest, etc.

                        '*Be sure to change what isLogin equals.*

                        'in the frmCreateAccount form, 
                        'you can change the default user type.
                        '==============================================

                    End If

                Else

                    'return 1 to the function
                    isLogin = 1

                End If

            Else
                'If the first username didn't match, go on to the second one until row 99 is met.
                If dbPos >= 99 Then
                    isLogin = 0
                Else
                    'Otherwise add one to the row position in the database
                    dbPos += 1
                End If
            End If
        End While

        '===========================================================================================
        'This is the magic of the function.
        'In the cmdLogin button, 
        'it runs this function and checks to see if the returned value equals what isLogin equals.
        Return isLogin
        '===========================================================================================

    End Function

    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub
    Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'This loads data into the 'DbDataSet.USERINFO' table.
        Me.dbTableAdapter.Fill(Me.DbDataSet.USERINFO)

        'Makes sure the first row is not empty, which would mean its the admin

        If DbDataSet.USERINFO(1).Username <> "Admin" Then

            'Make the admin account
            Dim newRow As DataRow = DbDataSet.USERINFO.NewRow()



            '====================================================================
            '==========This account will be the default admin account.===========
            '====================================================================



            '==============================================
            'Username for the default admin account. 
            newRow(0) = "Admin"
            'Password for the default admin account.
            'I recommend changing this as soon as possible.
            newRow(1) = "Password123"
            '===============================================


            newRow(2) = "Admin"


            '=======================================================
            'This will make sure that the Unique Identifier will be 
            '00000000-0000-0000-0000-000000000000
            newRow(3) = Guid.Empty
            '=======================================================

            DbDataSet.USERINFO.Rows.Add(newRow)
            'Save to the dataset
            Me.Validate()
            'Save dataset to database
            Me.dbBindingSource.EndEdit()
            'Update global tables
            Me.TableAdapterManager.UpdateAll(Me.DbDataSet)
        End If
    End Sub
    Private Sub cmdCreate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCreate.Click
        frmCreateAccount.Visible = True
    End Sub
    Private Sub cmdBackground_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBackground.Click
        'The following subs shows the color dialog,
        'And then sets the appropirate aspect in each form depending on the selected color in the dialog.
        diaColor.ShowDialog()

        Me.BackColor = diaColor.Color
        frmEdit.BackColor = diaColor.Color
        frmEdit.DataGridView1.BackgroundColor = diaColor.Color
        frmCreateAccount.BackColor = diaColor.Color
        mainMenu.BackColor = diaColor.Color
    End Sub
    Private Sub cmdText_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdText.Click
        diaColor.ShowDialog()

        lblPassword.ForeColor = diaColor.Color
        lblUsername.ForeColor = diaColor.Color
        cmdLogin.ForeColor = diaColor.Color
        cmdCreate.ForeColor = diaColor.Color
        cmdBackground.ForeColor = diaColor.Color
        cmdColors.ForeColor = diaColor.Color
        cmdEdit.ForeColor = diaColor.Color
        cmdFile.ForeColor = diaColor.Color
        cmdText.ForeColor = diaColor.Color
        cmdExit.ForeColor = diaColor.Color
        cmdButton.ForeColor = diaColor.Color

        'frmCreateAccount.lblUsername.foreColor = diaColor.Color

    End Sub
    Private Sub cmdButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdButton.Click
        diaColor.ShowDialog()

        cmdLogin.BackColor = diaColor.Color
        cmdCreate.BackColor = diaColor.Color
        cmdBackground.BackColor = diaColor.Color
        cmdColors.BackColor = diaColor.Color
        cmdEdit.BackColor = diaColor.Color
        cmdFile.BackColor = diaColor.Color
        cmdText.BackColor = diaColor.Color
        cmdExit.BackColor = diaColor.Color
        cmdButton.BackColor = diaColor.Color

        frmCreateAccount.OK_Button.ForeColor = diaColor.Color
        frmCreateAccount.Cancel_Button.ForeColor = diaColor.Color

        frmEdit.cmdAddNew.BackColor = diaColor.Color
        frmEdit.cmdCopy.BackColor = diaColor.Color
        frmEdit.cmdCut.BackColor = diaColor.Color
        frmEdit.cmdDelete.BackColor = diaColor.Color
        frmEdit.cmdExit.BackColor = diaColor.Color
        frmEdit.cmdFile.BackColor = diaColor.Color
        frmEdit.cmdHelp.BackColor = diaColor.Color
        frmEdit.cmdLastItem.BackColor = diaColor.Color
        frmEdit.cmdLogin.BackColor = diaColor.Color
        frmEdit.cmdMoveFirst.BackColor = diaColor.Color
        frmEdit.cmdNew.BackColor = diaColor.Color
        frmEdit.cmdNext.BackColor = diaColor.Color
        frmEdit.cmdOpen.BackColor = diaColor.Color
        frmEdit.cmdPaste.BackColor = diaColor.Color
        frmEdit.cmdPrevious.BackColor = diaColor.Color
        frmEdit.cmdPrint.BackColor = diaColor.Color
        frmEdit.cmdSave.BackColor = diaColor.Color
    End Sub
End Class

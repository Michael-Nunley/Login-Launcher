Public Class frmUser
    Dim example As New lol
    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        frmLogin.Close()
        frmEdit.Close()
        frmCreateAccount.Close()
        Me.Close()
    End Sub
    Private Sub cmdTest_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdTest.Click
        MsgBox(example.GetValue())
    End Sub
    Dim isOn As Boolean
    Private Sub cmdGenerate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGenerate.Click
        If isOn Then
            cmdGenerate.Text = "False"
            isOn = False
            tmrRandom.Enabled = False
        Else
            cmdGenerate.Text = "True"
            isOn = True
            tmrRandom.Enabled = True
        End If
    End Sub
    Private Sub tmrRandom_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrRandom.Tick
        example.AddRandom()
    End Sub

    Private Sub cmdTell_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdTell.Click
        MsgBox(example.ShowAll())
    End Sub
End Class
Module Module1
    Class lol
        Private _dictionary
        Public Sub New()
            ' Allocate and populate the field Dictionary.
            Me._dictionary = New Dictionary(Of String, Integer)
            Me._dictionary.Add("make", 552)
            Me._dictionary.Add("model", 44)
            Me._dictionary.Add("color", 12)
        End Sub
        Sub AddRandom()
            Dim random As New Random
            Me._dictionary.Add(random.Next.ToString, random.Next)
        End Sub
        Public Function ShowAll()
            Return Me._dictionary.ToList(Of String(2,2))
        End Function
        Public Function GetValue() As Integer
            ' Return value from private Dictionary.
            Dim input As String
            Dim random As New Random
            input = InputBox("hi")
            Try
                Return Me._dictionary.Item(input)
            Catch ex As Exception
                Me._dictionary.Add(input, Random.Next)
                Return Me._dictionary.Item(input)
            End Try
        End Function
    End Class
End Module
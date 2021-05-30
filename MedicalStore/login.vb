Public Class login
    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim username As String
        Dim password As String
        username = TextBox1.Text
        password = TextBox2.Text
        If username = "kunal" And password = "12345" Then
            Software.Show()
            Me.Hide()
        ElseIf username <> "kunal" And password <> "12345" Then
            MessageBox.Show("Invalid username and password")
        ElseIf username = "kunal" And password <> "12345" Then
            MessageBox.Show("Invalid password")
        Else
            MessageBox.Show("Invalid username")
        End If
    End Sub
End Class

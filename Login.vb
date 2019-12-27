Public Class Login
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
    Dim a As Integer = 0
    Private Sub Save_Click(sender As Object, e As EventArgs) Handles Save.Click
        If Not Usernamefield.Text = "" Then
            a += 1
        End If
        If Not PasswordField.Text = "" Then
            a += 1

        End If
        If a = 2 Then
            My.Settings.Username = Usernamefield.Text
            My.Settings.Password = PasswordField.Text
            My.Settings.Save()
        End If
        MsgBox("Register Succesful", MsgBoxStyle.Information)
        Loginpage.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Loginpage.Show()
    End Sub
End Class

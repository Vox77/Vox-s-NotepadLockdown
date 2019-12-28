Public Class Loginpage
    Dim a As Integer = 0
    Private Sub Save_Click(sender As Object, e As EventArgs) Handles Save.Click
        If Usernametextfield.Text = My.Settings.Username Then
            a += 1
        End If
        If Passwordtextfield.Text = My.Settings.Password Then
            a += 1
        End If
        If a = 2 Then
            MsgBox("You're In", MsgBoxStyle.Information)
            Notepad.Show()
            Me.Close()
        Else
            MsgBox("Good Try Dumbass", MsgBoxStyle.Critical)

        End If
    End Sub

    Private Sub Usernametextfield_TextChanged(sender As Object, e As EventArgs) Handles Usernametextfield.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Login.Show()
        Me.Close()
    End Sub

    Private Sub Loginpage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MsgBox("Made By @vox776 on twitter")
    End Sub
End Class
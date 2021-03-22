
Public Class admin_login
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBoxuser.Text = My.Settings.adminuser And TextBoxpass.Text = My.Settings.adminpass Then
            Call admin()
        ElseIf TextBoxuser.Text = My.Settings.useruser And TextBoxpass.Text = My.Settings.userpass Then
            Call user()
        ElseIf TextBoxuser.Text = "" And TextBoxpass.Text = "" Then
            MsgBox("please fill all textbox")
            TextBoxuser.Focus()
        ElseIf TextBoxuser.Text <> My.Settings.adminuser And TextBoxuser.Text <> My.Settings.useruser Then
            MsgBox("username is not correct")
            TextBoxuser.Focus()
            Return
        Else
            MsgBox("password is not correct!")

        End If
    End Sub

    Private Sub admin()
        view_data.Show()
        Me.Hide()

    End Sub
    Private Sub user()

    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim IExit As DialogResult
        IExit = MessageBox.Show("Sure to exit", "Close Application", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If IExit = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub Admin_login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
Imports System.Data.SqlClient

Public Class cust_login
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim connection As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Ritika\source\repos\pr\pr\Database1.mdf;Integrated Security=True")
        Dim command As New SqlCommand("select * from dataT where username=@username and password=@password", connection)
        command.Parameters.Add("username", SqlDbType.VarChar).Value = TextBoxusername.Text
        command.Parameters.Add("password", SqlDbType.VarChar).Value = TextBoxpassword.Text

        Dim adapter As New SqlDataAdapter(command)

        Dim table As New DataTable()
        adapter.Fill(table)
        If table.Rows.Count() <= 0 Then
            MessageBox.Show("username and password are invalid")
            TextBoxpassword.Clear()
            TextBoxusername.Clear()
        Else
            customviewpage.Show()

        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        reg_page.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim IExit As DialogResult
        IExit = MessageBox.Show("Sure to exit", "Close Application", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If IExit = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub TextBoxpassword_TextChanged(sender As Object, e As EventArgs) Handles TextBoxpassword.TextChanged

    End Sub

    Private Sub Cust_login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


End Class

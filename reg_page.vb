Imports System.Data.SqlClient

Public Class reg_page
    Dim con As New SqlConnection
    Dim cmd As New SqlCommand
    Private Sub reg_page_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        con.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Ritika\source\repos\pr\pr\Database1.mdf;Integrated Security=True"
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        con.Open()
        TextBox4.Text = Date.Today.ToString("dd-mm-yyyy")

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim con As New SqlConnection
            Dim cmd As New SqlCommand
            Dim dr As SqlDataReader

            con.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Ritika\source\repos\pr\pr\Database1.mdf;Integrated Security=True"
            con.Open()
            cmd.Connection = con
            cmd.CommandText = CommandType.Text
            cmd.CommandText = "select * from dataT where username='" & TextBox1.Text & "'"
            dr = cmd.ExecuteReader
            If dr.HasRows Then
                MsgBox("user name already exist", MsgBoxStyle.Critical)
                con.Close()
                con.Open()

                If (String.IsNullOrEmpty(TextBox1.Text) Or String.IsNullOrEmpty(TextBox2.Text) Or String.IsNullOrEmpty(TextBox3.Text) Or String.IsNullOrEmpty(TextBox4.Text) Or String.IsNullOrEmpty(TextBox5.Text) Or String.IsNullOrEmpty(TextBox6.Text) Or String.IsNullOrEmpty(TextBox7.Text) Or String.IsNullOrEmpty(TextBox8.Text) Or String.IsNullOrEmpty(ComboBox1.SelectedItem) Or String.IsNullOrEmpty(ComboBox2.SelectedItem)) Then
                    MessageBox.Show("please enter the details")
                Else
                    cmd = New SqlCommand("insert into dataT values('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & ComboBox1.Text & "','" & TextBox4.Text & "','" & TextBox5.Text & "','" & TextBox6.Text & "','" & ComboBox2.Text & "','" & TextBox7.Text & "','" & TextBox8.Text & "')", con)
                    cmd.ExecuteNonQuery()
                    MsgBox("successfully registered", MsgBoxStyle.Information, "success")
                    TextBox1.Clear()
                    TextBox2.Clear()
                    TextBox3.Clear()
                    TextBox4.Clear()
                    ComboBox1.Text = ""
                    TextBox5.Clear()
                    TextBox6.Clear()
                    ComboBox2.Text = ""
                    TextBox7.Clear()
                    TextBox8.Clear()
                    Me.Hide()
                End If
                con.Close()
            End If
            con.Close()
        Catch ex As Exception
            MsgBox("please enter correct details")
        End Try

        If (TextBox1.Text = "" And TextBox2.Text = "" And TextBox3.Text = "" And TextBox5.Text = "" And TextBox6.Text = "" And ComboBox2.Text = "" And TextBox7.Text = "" And TextBox8.Text = "") Then
            MessageBox.Show("please enter the details")
        Else
            cmd = con.CreateCommand()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "insert into dataT values('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & ComboBox1.Text & "','" & TextBox4.Text & "','" & TextBox5.Text & "','" & TextBox6.Text & "','" & ComboBox2.Text & "','" & TextBox7.Text & "','" & TextBox8.Text & "')"
            cmd.ExecuteNonQuery()
            MsgBox("successfully registered", MsgBoxStyle.Information, "success")
            Me.Hide()
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim IExit As DialogResult
        IExit = MessageBox.Show("Sure to exit", "Close Application", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If IExit = DialogResult.Yes Then
            Me.Hide()
        End If
    End Sub

    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs) Handles TextBox6.TextChanged

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged

    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged

    End Sub
End Class
Imports System.Data.SqlClient
Public Class menu1
    Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Ritika\source\repos\pr\pr\Database1.mdf;Integrated Security=True")
    Dim cmd As New SqlCommand
    Private Sub CheckBox6_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox6.CheckedChanged

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click
        Dim sum1 As Integer = 0
        If CheckBox1.Checked = True Then
            sum1 = sum1 + 20
        End If

        If CheckBox2.Checked = True Then
            sum1 = sum1 + 20

        End If
        If CheckBox3.Checked = True Then
            sum1 = sum1 + 35
        End If
        If CheckBox4.Checked = True Then
            sum1 = sum1 + 20
        End If
        If CheckBox5.Checked = True Then
            sum1 = sum1 + 30
        End If
        If CheckBox6.Checked = True Then
            sum1 = sum1 + 30
        End If

        If CheckBox7.Checked = True Then
            sum1 = sum1 + 90
        End If
        If CheckBox8.Checked = True Then
            sum1 = sum1 + 70
        End If
        If CheckBox9.Checked = True Then
            sum1 = sum1 + 80
        End If
        If CheckBox10.Checked = True Then
            sum1 = sum1 + 50
        End If
        If CheckBox11.Checked = True Then
            sum1 = sum1 + 120
        End If
        If CheckBox12.Checked = True Then
            sum1 = sum1 + 140
        End If
        If CheckBox13.Checked = True Then
            sum1 = sum1 + 140
        End If
        If CheckBox14.Checked = True Then
            sum1 = sum1 + 90
        End If
        If CheckBox15.Checked = True Then
            sum1 = sum1 + 40
        End If
        If CheckBox16.Checked = True Then
            sum1 = sum1 + 40
        End If
        If CheckBox17.Checked = True Then
            sum1 = sum1 + 55
        End If
        If CheckBox18.Checked = True Then
            sum1 = sum1 + 60
        End If
        If CheckBox19.Checked = True Then
            sum1 = sum1 + 30
        End If
        TextBox1.Text = sum1

        Dim pass As String = "sum1"
        Dim frm As New Form6(pass)



    End Sub


    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Menu1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub CheckBox16_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox16.CheckedChanged

    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click

        If String.IsNullOrEmpty(TextBox2.Text) Then
            MsgBox("enter your name first")
        Else


            Dim checked As String
            Dim ch As String
            checked = " "
            ch = " "
            ch = TextBox2.Text
            If CheckBox1.Checked = True Then
                checked = checked + CheckBox1.Text
            End If

            If CheckBox19.Checked = True Then
                checked = checked & CheckBox19.Text
            End If
            If CheckBox2.Checked = True Then
                checked = checked + CheckBox2.Text
            End If

            If CheckBox3.Checked = True Then
                checked = checked + CheckBox3.Text
            End If

            If CheckBox4.Checked = True Then
                checked = checked + CheckBox4.Text
            End If

            If CheckBox5.Checked = True Then
                checked = checked + CheckBox5.Text
            End If

            If CheckBox6.Checked = True Then
                checked = checked + CheckBox6.Text
            End If

            If CheckBox7.Checked = True Then
                checked = checked + CheckBox7.Text
            End If

            If CheckBox8.Checked = True Then
                checked = checked + CheckBox8.Text
            End If

            If CheckBox9.Checked = True Then
                checked = checked + CheckBox9.Text
            End If

            If CheckBox10.Checked = True Then
                checked = checked + CheckBox10.Text
            End If

            If CheckBox11.Checked = True Then
                checked = checked + CheckBox11.Text
            End If

            If CheckBox12.Checked = True Then
                checked = checked + CheckBox12.Text
            End If

            If CheckBox13.Checked = True Then
                checked = checked + CheckBox13.Text
            End If

            If CheckBox14.Checked = True Then
                checked = checked + CheckBox14.Text
            End If

            If CheckBox15.Checked = True Then
                checked = checked + CheckBox15.Text
            End If

            If CheckBox16.Checked = True Then
                checked = checked + CheckBox16.Text
            End If

            If CheckBox17.Checked = True Then
                checked = checked + CheckBox17.Text
            End If

            If CheckBox18.Checked = True Then
                checked = checked + CheckBox18.Text
            End If
            MsgBox(checked)
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
            con.Open()
            cmd = con.CreateCommand()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "insert into able  values('" & ch & "','" & checked & "')"
            cmd.ExecuteNonQuery()
            'MsgBox("inserted successfully")

            Dim sp As String = TextBox1.Text
            Dim ps As String = TextBox2.Text
            Dim frm As New Form1(sp, ps)
            frm.ShowDialog()
        End If

    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click

        customviewpage.Show()
    End Sub

End Class
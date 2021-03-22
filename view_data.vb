Imports System.Data.SqlClient

Public Class view_data
    Dim con As New SqlConnection
    Dim cmd As New SqlCommand

    Private Sub view_data_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        con.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Ritika\source\repos\pr\pr\Database1.mdf;Integrated Security=True"
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        con.Open()
        DataGridView1.Hide()
        filterdata("")
        TextBox1.Hide()
        Button1.Hide()
    End Sub
    Public Sub disp_data()

        cmd = con.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select * from dataT"
        cmd.ExecuteNonQuery()

        Dim dt As New DataTable()
        Dim da As New SqlDataAdapter(cmd)
        da.Fill(dt)
        DataGridView1.DataSource = dt

    End Sub

    Public Sub disp_data1()

        cmd = con.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select * from able"
        cmd.ExecuteNonQuery()

        Dim td As New DataTable()
        Dim ad As New SqlDataAdapter(cmd)
        ad.Fill(td)
        DataGridView1.DataSource = td

    End Sub

    Private Sub CustomerregistationdetailsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CustomerregistationdetailsToolStripMenuItem.Click
        Button1.Show()
        TextBox1.Show()
        DataGridView1.Show()
        disp_data()

    End Sub

    Private Sub TodaysItemOrderedToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TodaysItemOrderedToolStripMenuItem.Click
        Button1.Hide()
        TextBox1.Hide()
        DataGridView1.Show()
        disp_data1()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        filterdata(TextBox1.Text)
    End Sub

    Public Sub filterdata(valuetosearch As String)
        'Select * From dataT where concat(username,password,Name,gender,delivery_add,pincode,state,contact_no,email_id) Like'%F%'
        Dim searchquery As String = "Select * From dataT where concat(username,password,Name,gender,delivery_add,pincode,state,contact_no,email_id) Like'%" & valuetosearch & "%'"
        Dim command As New SqlCommand(searchquery, con)
        Dim adapter As New SqlDataAdapter(command)
        Dim table As New DataTable()
        adapter.Fill(table)
        DataGridView1.DataSource = table
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        filterdata(TextBox1.Text)
    End Sub

    Private Sub d(sender As Object, e As EventArgs) Handles MyBase.Click

    End Sub

    Private Sub DeliveryaddressToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeliveryaddressToolStripMenuItem.Click
        Button1.Hide()
        TextBox1.Hide()
        DataGridView1.Show()
        disp_data2()
    End Sub

    Public Sub disp_data2()

        cmd = con.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select * from Table2"
        cmd.ExecuteNonQuery()

        Dim dt As New DataTable()
        Dim da As New SqlDataAdapter(cmd)
        da.Fill(dt)
        DataGridView1.DataSource = dt

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class
Imports MySql.Data.MySqlClient
Public Class Form17
    Dim con As New MySqlConnection
    Dim cmd As New MySqlCommand

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        cmd = con.CreateCommand
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select * from miscellaneous.additem where orderno='" + TextBox1.Text + "'"
        cmd.ExecuteNonQuery()
        Dim dt As New DataTable
        Dim da As New MySqlDataAdapter(cmd)
        da.Fill(dt)
        DataGridView1.DataSource = dt



    End Sub

    Private Sub Form17_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con.ConnectionString = "server=localhost; user id=root; password=vivek; database=miscellaneous;  "
        If con.State = ConnectionState.Open Then
            con.Close()

        End If

        con.Open()
        connect()
        cmd = con.CreateCommand
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select sum(price) from miscellaneous.additem"
        cmd.ExecuteNonQuery()
        Dim dt2 As New DataTable
        Dim da2 As New MySqlDataAdapter(cmd)
        da2.Fill(dt2)
        DataGridView2.DataSource = dt2
    End Sub
    Public Sub connect()
        cmd = con.CreateCommand
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select * from miscellaneous.additem"
        cmd.ExecuteNonQuery()

        Dim dt As New DataTable
        Dim da As New MySqlDataAdapter(cmd)
        da.Fill(dt)
        DataGridView1.DataSource = dt
    End Sub
End Class
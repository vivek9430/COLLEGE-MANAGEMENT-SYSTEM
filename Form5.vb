Imports MySql.Data.MySqlClient
Public Class Form5
    Dim con As New MySqlConnection
    Dim cmd As New MySqlCommand
    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con.ConnectionString = "server=localhost; user id=root; password=vivek; database=fees;  "
        If con.State = ConnectionState.Open Then
            con.Close()

        End If

        con.Open()
    End Sub
    Public Sub connect()
        cmd = con.CreateCommand
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select * from fees.submit"
        cmd.ExecuteNonQuery()
        Dim dt As New DataTable
        Dim da As New MySqlDataAdapter(cmd)
        da.Fill(dt)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        cmd = con.CreateCommand
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "insert into submit values('" + TextBox1.Text + "','" + TextBox2.Text + "','" + ComboBox1.Text + "','" + DateTimePicker1.Text + "','" + TextBox4.Text + "')"
        cmd.ExecuteNonQuery()
        connect()
        TextBox1.Text = ""
        TextBox2.Text = ""
        ComboBox1.Text = ""
        DateTimePicker1.Text = ""
        TextBox4.Text = ""


    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Close()
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs)

    End Sub
End Class
Imports MySql.Data.MySqlClient
Public Class Form15
    Dim con As New MySqlConnection
    Dim cmd As New MySqlCommand

    Private Sub Form15_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
        con.ConnectionString = "server=localhost; user id=root; password=vivek; database=attendance;  "
        If con.State = ConnectionState.Open Then
            con.Close()

        End If

        con.Open()
    End Sub
    Public Sub connect()
        cmd = con.CreateCommand
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select * from attendance.detail"
        cmd.ExecuteNonQuery()
        Dim dt As New DataTable
        Dim da As New MySqlDataAdapter(cmd)
        da.Fill(dt)

    End Sub

    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        cmd = con.CreateCommand
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "insert into detail values('" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "','" + TextBox4.Text + "')"
        cmd.ExecuteNonQuery()
        connect()
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""



    End Sub

    Private Sub Label14_Click(sender As Object, e As EventArgs) Handles Label14.Click

    End Sub

    Private Sub Label13_Click(sender As Object, e As EventArgs) Handles Label13.Click

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label14.Text = DateTime.Now.ToLongDateString()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub TextBox10_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
    End Sub
End Class
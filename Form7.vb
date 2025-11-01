Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data.MySqlClient
Public Class Form7
    Dim con As New MySqlConnection
    Dim cmd As New MySqlCommand
    Private Sub Form7_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con.ConnectionString = "server=localhost; user id=root; password=vivek; database=teacher;  "
        If con.State = ConnectionState.Open Then
            con.Close()

        End If

        con.Open()
    End Sub
    Public Sub connect()
        cmd = con.CreateCommand
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select * from teacher.information"
        cmd.ExecuteNonQuery()
        Dim dt As New DataTable
        Dim da As New MySqlDataAdapter(cmd)
        da.Fill(dt)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        cmd = con.CreateCommand
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "insert into information values('" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "','" + ComboBox1.Text + "','" + RichTextBox2.Text + "','" + TextBox5.Text + "')"
        cmd.ExecuteNonQuery()
        connect()
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        ComboBox1.Text = ""
        RichTextBox2.Text = ""
        TextBox5.Text = ""
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
    End Sub
End Class
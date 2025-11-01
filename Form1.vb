Public Class Form1

    Dim k As Integer = 1

    Private Sub Label6_Click(sender As Object, e As EventArgs)

    End Sub




    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        If String.IsNullOrEmpty(TextBox1.Text) Then
            ErrorProvider1.SetError(TextBox1, "textbox 1 can't be blank")
        Else
            ErrorProvider1.SetError(TextBox1, String.Empty)

        End If
        If String.IsNullOrEmpty(TextBox2.Text) Then
            ErrorProvider1.SetError(TextBox2, "textbox 1 can't be blank")
        Else
            ErrorProvider1.SetError(TextBox2, String.Empty)
        End If
        Dim i = True
        If TextBox1.Text.Equals("vivek1234@yahoo") Then
        Else
            MsgBox("userid incorrect")
            i = False
        End If
        If TextBox2.Text.Equals("vg1234") Then
        Else
            MsgBox("password incorrect")
            i = False


        End If
        If i Then
            Button1.Text = "successfully"
            Dim j = New Form3
            j.Show()

        Else
            Button1.Text = "unsuccessfully"
        End If


    End Sub



    Private Sub Timer1_Tick_1(sender As Object, e As EventArgs) Handles Timer1.Tick
        Select Case k
            Case 1
                PictureBox1.Image = Image.FromFile("C:\Users\Vivek\Downloads\fig1.jpeg")
            Case 2
                PictureBox1.Image = Image.FromFile("C:\Users\Vivek\Downloads\fig5.png")
            Case 3
                PictureBox1.Image = Image.FromFile("C:\Users\Vivek\Downloads\fig4.jpg")
            Case 4

                PictureBox1.Image = Image.FromFile("C:\Users\Vivek\Downloads\fig6.jpg")
        End Select




        k += 1
        If k > 4 Then
            k = 1
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
        TextBox1.Text = "vivek1234@yahoo"
        TextBox2.Text = "vg1234"


    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click


    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Close()
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs)
        Dim v = New Form2
        v.Show()
    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs)

    End Sub

    Private Sub Label4_Click_1(sender As Object, e As EventArgs) Handles Label4.Click
        Dim v = New Form2
        v.Show()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged


    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Me.Close()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class


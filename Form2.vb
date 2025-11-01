Public Class Form2
    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs) Handles TextBox6.TextChanged

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged

    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click

    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles TextBox5.TextChanged

    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub RichTextBox1_TextChanged(sender As Object, e As EventArgs) Handles RichTextBox1.TextChanged

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim k As Boolean = True
        ComboBox1.Text = "bca"

        If TextBox1.Text.Equals("vivek") Then


        Else
            MsgBox("u incorrect")
            k = False
        End If
        If TextBox3.Text.Equals("1234") Then

        Else
            MsgBox("userid incorrect")
            k = False
        End If
        If ComboBox1.Text.Equals("bca") Then

        Else
            MsgBox("course incorrect")
            k = False
        End If

        If RichTextBox1.Text.Equals("station") Then

        Else
            MsgBox("address incorrect")
            k = False
        End If

        If TextBox5.Text.Equals("vg1234") Then

        Else
            MsgBox("email incorrect")
            k = False
        End If
        If TextBox7.Text.Equals("9430") Then

        Else
            MsgBox("password incorrect")
            k = False
        End If
        If TextBox6.Text.Equals("8544011572") Then

        Else
            MsgBox("phoneno incorrect")
            k = False


        End If
        If k Then
            Button1.Text = "succesfully"
        Else
            Button1.Text = "unsuccessfully"
        End If
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
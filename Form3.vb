Imports System.Security.Cryptography

Public Class Form3
    Private Sub CoolegeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CoolegeToolStripMenuItem.Click

    End Sub

    Private Sub NEWADDMISSIONToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NEWADDMISSIONToolStripMenuItem.Click
        Dim i = New Form4()
        i.Show()
        i.MdiParent = Me

    End Sub

    Private Sub FEEDETAILSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FEEDETAILSToolStripMenuItem.Click
        Dim i = New Form5()
        i.Show()
        i.MdiParent = Me
    End Sub

    Private Sub SEARCHSTUDENTToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SEARCHSTUDENTToolStripMenuItem.Click
        Dim a = New Form6()
        a.Show()
        a.MdiParent = Me
    End Sub

    Private Sub ADDTEACHERINFORMATIONToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ADDTEACHERINFORMATIONToolStripMenuItem.Click
        Dim b = New Form7()
        b.Show()
        b.MdiParent = Me
    End Sub

    Private Sub SEARCHTEACHERToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SEARCHTEACHERToolStripMenuItem.Click
        Dim c = New Form9()
        c.Show()
        c.MdiParent = Me
    End Sub

    Private Sub REMOVESTUDENTDETAILSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles REMOVESTUDENTDETAILSToolStripMenuItem.Click
        Dim d = New Form8
        d.Show()
        d.MdiParent = Me
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TEACHERToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TEACHERToolStripMenuItem.Click

    End Sub

    Private Sub FEESToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FEESToolStripMenuItem.Click

    End Sub

    Private Sub ADDNEWSTUDENTToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ADDNEWSTUDENTToolStripMenuItem.Click
        Dim b = New Form11
        b.Show()
        b.MdiParent = Me

    End Sub

    Private Sub STUDEToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles STUDEToolStripMenuItem.Click
        Dim i = New Form12()
        i.Show()
        i.MdiParent = Me
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        Dim i = New Form11()
        i.Show()
        i.MdiParent = Me
    End Sub

    Private Sub DELETETEACHERRECORDSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DELETETEACHERRECORDSToolStripMenuItem.Click
        Dim i = New Form13
        i.Show()
        i.MdiParent = Me
    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()


    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs)


    End Sub

    Private Sub ATTENDANCERECORDOFSTUDENTToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Dim i = New Form14
        i.Show()
        i.MdiParent = Me
    End Sub

    Private Sub ATTENDANCESYSTEMToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ToolStripComboBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)
        Dim i = New Form14
        i.Show()
        i.MdiParent = Me
    End Sub

    Private Sub Label1_Click_1(sender As Object, e As EventArgs)
        Dim k = New Form14
        k.Show()
        k.MdiParent = Me
    End Sub

    Private Sub ATTENDANCEDETAILToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ATTENDANCEDETAILToolStripMenuItem.Click
        Dim I = New Form14()
        I.Show()
        I.MdiParent = Me
    End Sub

    Private Sub ATTENANCERECORDSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ATTENANCERECORDSToolStripMenuItem.Click
        Dim i = New Form15()
        i.Show()
        i.MdiParent = Me
    End Sub

    Private Sub MISCELLANEOUSEXPToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MISCELLANEOUSEXPToolStripMenuItem.Click
        Dim I = New Form16()
        I.Show()
        I.MdiParent = Me
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
    End Sub

    Private Sub SHOWITEMToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SHOWITEMToolStripMenuItem.Click
        Dim I = New Form17()
        I.Show()
        I.MdiParent = Me
    End Sub

    Private Sub UPDATESTUDENTDETAILToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UPDATESTUDENTDETAILToolStripMenuItem.Click
        Dim I = New Form18()
        I.Show()
        I.MdiParent = Me
    End Sub

    Private Sub TEACHERSALARYToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TEACHERSALARYToolStripMenuItem.Click
        Dim I = New Form19()
        I.Show()
        I.MdiParent = Me
    End Sub



    Private Sub RESULTToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RESULTToolStripMenuItem.Click
        Dim I = New Form21
        I.Show()
        I.MdiParent = Me
    End Sub

    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub

    Private Sub ToolStripMenuItem4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub DATEToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DATEToolStripMenuItem.Click

    End Sub

    Private Sub Timer1_Tick_1(sender As Object, e As EventArgs) Handles Timer1.Tick
        DATEToolStripMenuItem.Text = DateTime.Now.ToLongDateString()
        TIMEToolStripMenuItem.Text = DateTime.Now.ToLongTimeString()
    End Sub

    Private Sub TIMEToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TIMEToolStripMenuItem.Click

    End Sub

    Private Sub LOGOUTToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LOGOUTToolStripMenuItem.Click
        Me.Close()

    End Sub

    Private Sub ATTENDANCESYSTEMToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles ATTENDANCESYSTEMToolStripMenuItem.Click

    End Sub
End Class
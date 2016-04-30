Imports System.Drawing.Printing



Public Class formsuivie



    Private Sub formsuivie_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        TextBox1.Text = Form1.TextBox1.Text

        TextBox7.Text = Form1.TextBox7.Text
        TextBox3.Text = Form1.TextBox6.Text
        TextBox4.Text = Form1.TextBox5.Text
        TextBox6.Text = Form1.TextBox4.Text
        TextBox2.Text = Form1.TextBox3.Text
        TextBox5.Text = Form1.nomMed.Text

    End Sub
   


    Private Sub PrintPreviewDialog1_Load(sender As Object, e As EventArgs) Handles PrintPreviewDialog1.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Button1.Visible = False
        PrintForm1.PrintAction = Printing.PrintAction.PrintToPreview


        PrintForm1.Print()

    End Sub

   
End Class
Public Class PAGE_DE_CONNEXION

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim nar As String
        Dim vr As String

        nar = "admin"
        vr = "admin"
        If (nar = TextBox1.Text) And (vr = TextBox2.Text) Then
            MsgBox("authentification validé")
            pageaccueil.Show()

            Me.Hide()
        Else
            MsgBox("mot de passe incorrect!!!!")
        End If



    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        MsgBox("voulez vous quitter?")

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox1.Text = " "
        TextBox2.Text = " "
    End Sub
End Class
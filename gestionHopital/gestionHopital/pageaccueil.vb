Public Class pageaccueil

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MsgBox("voulez vous quitter l 'application?")
        Me.Close()


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        formulerecherche.Show()
        Me.Hide()

    End Sub
End Class
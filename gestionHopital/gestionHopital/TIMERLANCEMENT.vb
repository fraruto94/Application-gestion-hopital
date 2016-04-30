Public Class TIMERLANCEMENT
    Dim seconde = 0
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        seconde = seconde + 1
        ProgressBar1.Value = 10
        If (seconde <> 9) Then

            ProgressBar1.Value = 100



        Else
            PAGE_DE_CONNEXION.Show()
            Me.Hide()

        End If
        If (ProgressBar1.Value > 100) Then
            ProgressBar1.Value = 0
        End If

    End Sub

    Private Sub ProgressBar1_Click(sender As Object, e As EventArgs) Handles ProgressBar1.Click

    End Sub
End Class
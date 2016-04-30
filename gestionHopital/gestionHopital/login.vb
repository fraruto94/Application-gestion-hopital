Public Class login
    Dim medecin As New TabControl
    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            TextBox2.UseSystemPasswordChar = False

        End If
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim nar As String
        Dim vr As String

        nar = "medecin"
        vr = "malade"
        If (nar = TextBox1.Text) And (vr = TextBox2.Text) Then
            MsgBox("authentification validé")
            Form1.Show()
            Form1.medecin.SelectedIndex = 0
            Form1.TabPage3.Enabled = False
            Form1.TabPage2.Enabled = False
            Form1.TabPage1.Enabled = True
            Form1.TabPage4.Enabled = False
            Form1.TabPage5.Enabled = False
            Form1.infirmier.Enabled = False
            Form1.malade.Enabled = False
            Me.Hide()
        

        End If

        If (choixservice.Button5.Enabled = True) Then
            nar = "infirmier"
            vr = "malade"
            If (nar = TextBox1.Text) And (vr = TextBox2.Text) Then
                MsgBox("authentification validé")
                Form1.Show()
                Form1.medecin.SelectedIndex = 1

                Form1.TabPage3.Enabled = False
                Form1.TabPage2.Enabled = False
                Form1.TabPage1.Enabled = False
                Form1.TabPage4.Enabled = False
                Form1.TabPage5.Enabled = False
                Form1.infirmier.Enabled = True
                Form1.malade.Enabled = True
          
            End If


        End If
        If (choixservice.Button6.Enabled = True) Then
            nar = "service"
            vr = "malade"
            If (nar = TextBox1.Text) And (vr = TextBox2.Text) Then
                MsgBox("authentification validé")
                Form1.Show()
                Me.Hide()
                Form1.medecin.SelectedIndex = 3
                Form1.TabPage3.Enabled = False
                Form1.TabPage2.Enabled = False
                Form1.TabPage1.Enabled = False
                Form1.TabPage4.Enabled = True
                Form1.TabPage5.Enabled = False
                Form1.infirmier.Enabled = False
                Form1.malade.Enabled = False

            End If
        End If
        If (choixservice.Button4.Enabled = True) Then
            nar = "hospitalisation"
            vr = "malade"
            If (nar = TextBox1.Text) And (vr = TextBox2.Text) Then
                MsgBox("authentification validé")
                Form1.Show()
                Me.Hide()
                Form1.medecin.SelectedIndex = 5
                Form1.TabPage3.Enabled = False
                Form1.TabPage2.Enabled = True
                Form1.TabPage1.Enabled = False
                Form1.TabPage4.Enabled = False
                Form1.TabPage5.Enabled = False
                Form1.infirmier.Enabled = False
                Form1.malade.Enabled = False
            End If
        End If
        If (choixservice.Button3.Enabled = True) Then
            nar = "batiment"
            vr = "malade"
            If (nar = TextBox1.Text) And (vr = TextBox2.Text) Then
                MsgBox("authentification validé")
                Form1.Show()
                Me.Hide()
                Form1.medecin.SelectedIndex = 5
                Form1.TabPage3.Enabled = False
                Form1.TabPage2.Enabled = True
                Form1.TabPage1.Enabled = False
                Form1.TabPage4.Enabled = False
                Form1.TabPage5.Enabled = False
                Form1.infirmier.Enabled = False
                Form1.malade.Enabled = False
          
            End If
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = " "
        TextBox2.Text = " "
    End Sub
End Class
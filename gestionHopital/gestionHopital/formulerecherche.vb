Imports MySql.Data.MySqlClient
Imports System.Data.DataTable



Public Class formulerecherche
    Private dt As DataTable
    Dim fou As DataTable
    Dim READER As MySqlDataReader
    Dim command As MySqlCommand
    Dim sda As New MySqlDataAdapter
    Dim bm As New BindingSource




    Private Sub Dgvrecherche_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Dgvrecherche.CellContentClick

    End Sub
    Public Sub actualiser()

        Dim con As New MySqlConnection("server=localhost; user id =root; password= ; database=gestionhospital;")

        con.Open()
        Dim com As String
        com = "SELECT * FROM  gestionhospital.specialite"
        Dim adapter As New MySqlCommand(com, con)
        sda.SelectCommand = adapter
        Dim fou As New DataTable
        sda.Fill(fou)
        bm.DataSource = fou
        Dgvrecherche.DataSource = bm
        sda.Update(fou)











    End Sub
    Private Sub formulerecherche_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim con As New MySqlConnection("server=localhost; user id =root; password= ; database=gestionhospital;")

        con.Open()
        Dim com As String
        com = "SELECT * FROM  specialite"
        Dim adapter As New MySqlDataAdapter(com, con)
        Dim fou2 As New DataTable

        adapter.Fill(fou2)
        Dgvrecherche.DataSource = fou2
        dt = fou2

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles rech.TextChanged
        dt.DefaultView.RowFilter = "NomSpecial Like'%" & rech.Text & "%' "








    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form1.Show()
        Me.Hide()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MsgBox("voulez vous quitter ?")
        Me.Close()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        actualiser()


        formulerecherche_Load(sender, e)



    End Sub

    Private Sub BindingNavigator1_RefreshItems(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)
        Form1.infirmier.Select()




    End Sub

    Private Sub Button4_Click_1(sender As Object, e As EventArgs) Handles Button4.Click
        choixservice.Show()
        Me.Hide()





    End Sub
End Class


Imports System.Drawing.Printing
Imports MySql.Data.MySqlClient
Imports System.Data.DataTable
Imports MySql.Data.Types.MySqlConversionException

Public Class Form1

    Public ligne As New Integer

    Dim soa As New MySqlDataAdapter
    Dim dataset As New DataTable
    Private dv As DataTable
    Private di As DataTable
    Private dm As DataTable
    Private ds As DataTable
    Private db As DataTable
    Private dsa As DataTable
    Private dsal As DataTable

    Dim source As New BindingNavigator
    Dim READER As MySqlDataReader
    Dim command As MySqlCommand
    Dim fou As New DataTable
    Dim sda As MySqlDataAdapter
    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles codeMed.TextChanged

    End Sub

    Private Sub TabPage1_Click(sender As Object, e As EventArgs) Handles TabPage1.Click
        '
        Dim command As New MySqlCommand

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Dgvmedecin.CellContentClick

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim con As New MySqlConnection("server=localhost; user id =root; password= ; database=gestionhospital;")

        con.Open()
        Dim com As String
        com = "SELECT * FROM  medecin"
        Dim adapter As New MySqlDataAdapter(com, con)
        Dim fou As New DataTable
        adapter.Fill(fou)
        Dgvmedecin.DataSource = fou
        dv = fou

        Dim ree As String
        ree = "SELECT * FROM infirmier"
        Dim adapter2 As New MySqlDataAdapter(ree, con)
        Dim inf As New DataTable
        adapter2.Fill(inf)
        DgvInfirmmier.DataSource = inf
        di = inf


        Dim re As String
        re = "SELECT * FROM malade"
        Dim adapter3 As New MySqlDataAdapter(re, con)
        Dim ze As New DataTable
        adapter3.Fill(ze)
        Dgvmalade.DataSource = ze
        dm = ze

        Dim ri As String
        ri = "SELECT * FROM service"
        Dim adapter4 As New MySqlDataAdapter(ri, con)
        Dim zf As New DataTable
        adapter4.Fill(zf)
        Dgvservice.DataSource = zf
        ds = zf

        Dim ra As String
        ra = "SELECT * FROM batiment"
        Dim adapter5 As New MySqlDataAdapter(ra, con)
        Dim zo As New DataTable
        adapter5.Fill(zo)
        Dgvbatiment.DataSource = zo
        db = zo
        Dim rae As String
        rae = "SELECT * FROM salle"
        Dim adapter6 As New MySqlDataAdapter(rae, con)
        Dim zof As New DataTable
        adapter6.Fill(zof)
        dgvsalle.DataSource = zof
        dsal = zof





        Dim rav As String
        rav = "SELECT * FROM hospitalisation"
        Dim adapter7 As New MySqlDataAdapter(rav, con)
        Dim zox As New DataTable
        adapter7.Fill(zox)
        Dgvhos.DataSource = zox
        dsa = zox


        Dgvmalade.Sort(Dgvmalade.Columns(0), System.ComponentModel.ListSortDirection.Ascending)




       
       

    

        Dgvmalade.Refresh()

        loadtable()
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles valider.Click
        Dim con = New MySqlConnection
        con.ConnectionString = "server=127.0.0.1; user id =root; password= ; database=gestionhospital;"
        Dim READER As MySqlDataReader
        Dim soa As New MySqlDataAdapter
        Dim dataset As New DataTable

        Dim source As New BindingSource

        Try
            con.Open()
            Dim query As String
            query = "insert into gestionhospital.medecin(NumSpecial,NomMedecin,code,Adresse,Numtel,PrenomMedecin)values('" & numspecial.Text & "','" & nomMed.Text & "','" & codeMed.Text & "','" & AdressMed.Text & "','" & NumMed.Text & "','" & prenomMed.Text & "')"
            command = New MySqlCommand(query, con)
            READER = command.ExecuteReader
            MessageBox.Show("medecin enregistre")
            soa.SelectCommand = command
            soa.Fill(dataset)
            source.DataSource = dataset
            Dgvmedecin.DataSource = source
            soa.Update(dataset)
            Dgvmedecin.Refresh()
            Form1_Load(sender, e)
        Catch ex As Exception
            con.Close()
        Finally
            con.Dispose()

        End Try
        Dgvmedecin.Refresh()

        loadtable()
    End Sub

    Private Sub update_Click(sender As Object, e As EventArgs) Handles update.Click
        Dim con = New MySqlConnection
        con.ConnectionString = "server=localhost; user id =root; password= ; database=gestionhospital;"
        Dim READER As MySqlDataReader
        Try
            con.Open()
            Dim query As String
            query = "UPDATE  gestionhospital.medecin SET NumSpecial= '" & numspecial.Text & " ',NomMedecin='" & nomMed.Text & "',code='" & codeMed.Text & "',Adresse='" & AdressMed.Text & "',Numtel='" & NumMed.Text & "',PrenomMedecin='" & prenomMed.Text & "' where code='" & codeMed.Text & "'"
            command = New MySqlCommand(query, con)
            READER = command.ExecuteReader
            MessageBox.Show("medecin mise a jour")

            Form1_Load(sender, e)
            Dgvmedecin.Refresh()
        Catch ex As Exception
            con.Close()
        Finally
            con.Dispose()
        End Try
    End Sub

    Private Sub loadtable()
        Dim con = New MySqlConnection
        con.ConnectionString = "server=localhost; user id =root; password= ; database=gestionhospital;"
        Dim READER As MySqlDataReader
        Dim soa As New MySqlDataAdapter
        Dim dataset As New DataSet
        Dim data As DataTable = Nothing
        Dim source As New BindingSource

        Try
            con.Open()
            Dim query As String
            query = "SELECT * FROM gestionhospital.medecin"
            command = New MySqlCommand(query, con)
            READER = command.ExecuteReader
            MessageBox.Show("medecin modifie")
            soa.SelectCommand = command
            soa.Fill(dataset)
            source.DataSource = dataset

            soa.Update(dataset)
            Dgvmedecin.Refresh()
            soa.Fill(dataset, "medecin")
            data = dataset.Tables("medecin")
            Dgvmedecin.DataSource = data
        Catch ex As Exception
            con.Close()
        Finally
            con.Dispose()

        End Try
    End Sub
    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles rafraichir.Click
        Form1_Load(sender, e)

    End Sub

    Private Sub loadinfirmier()
        Dim con = New MySqlConnection
        con.ConnectionString = "server=localhost; user id =root; password= ; database=gestionhospital;"
        Dim READER As MySqlDataReader
        Dim soa As New MySqlDataAdapter
        Dim dataset As New DataSet
        Dim data As DataTable = Nothing
        Dim source As New BindingSource

        Try
            con.Open()
            Dim query As String
            query = "SELECT * FROM gestionhospital.infirmier"
            command = New MySqlCommand(query, con)
            READER = command.ExecuteReader
            MessageBox.Show("infirmier modifie")
            soa.SelectCommand = command
            soa.Fill(dataset)
            source.DataSource = dataset

            soa.Update(dataset)
            Dgvmedecin.Refresh()
            soa.Fill(dataset, "infirmier")
            data = dataset.Tables("infirmier")
            DgvInfirmmier.DataSource = data

        Catch ex As Exception
            con.Close()
        Finally
            con.Dispose()

        End Try
    End Sub

    Private Sub infirmier_Click(sender As Object, e As EventArgs) Handles infirmier.Click
        Form1_Load(sender, e)
        loadinfirmier()

    End Sub

    Private Sub Button1_Click_2(sender As Object, e As EventArgs) Handles Button1.Click
        Dim con = New MySqlConnection
        con.ConnectionString = "server=localhost; user id =root; password= ; database=gestionhospital;"
        Dim READER As MySqlDataReader
        Dim soa As New MySqlDataAdapter
        Dim dataset As New DataTable

        Dim source As New BindingSource

        Try
            con.Open()
            Dim query As String
            query = "insert into gestionhospital.infirmier(CodeService,CodeInfirmier,Numtel,Salaire,Horaire,NomInf,PrenomInf,AdresseInf)values('" & Codeservice.Text & "','" & codeinfirmie.Text & "','" & NumInf.Text & "','" & salaire.Text & "','" & horaire.Text & "','" & NomInf.Text & "','" & PrenomInf.Text & "','" & AdresseInf.Text & "')"
            command = New MySqlCommand(query, con)
            READER = command.ExecuteReader
            MessageBox.Show("infirmier enregistré")
            soa.SelectCommand = command
            soa.Fill(dataset)
            source.DataSource = dataset
            DgvInfirmmier.DataSource = source
            soa.Update(dataset)
            DgvInfirmmier.Refresh()
            Form1_Load(sender, e)


        Catch ex As Exception
            con.Close()
        Finally
            con.Dispose()
            Form1_Load(sender, e)
        End Try
        DgvInfirmmier.Refresh()

        Form1_Load(sender, e)
    End Sub

    Private Sub malade_Click(sender As Object, e As EventArgs) Handles malade.Click

    End Sub

    Private Sub TabPage4_Click(sender As Object, e As EventArgs) Handles TabPage4.Click

    End Sub

    Private Sub TabPage2_Click(sender As Object, e As EventArgs) Handles TabPage2.Click

    End Sub

    Private Sub TabPage3_Click(sender As Object, e As EventArgs) Handles TabPage3.Click
        Dim con As New MySqlConnection("server=localhost; user id =root; password= ; database=gestionhospital;")
        Dim READER As MySqlDataReader



        con.Open()
        Dim re As String
        re = "SELECT * FROM gestionhospital.malade"
        command = New MySqlCommand(re, con)
        READER = command.ExecuteReader
        While READER.Read
            Dim sname = READER.GetString("NomMalade")

            ComboBox1.Items.Add(sname)
        End While




        Form1_Load(sender, e)
    End Sub

    Private Sub annuler_Click(sender As Object, e As EventArgs) Handles annuler.Click
        numspecial.Text = " "
        nomMed.Text = " "
        codeMed.Text = " "
        AdressMed.Text = " "
        NumMed.Text = " "
        prenomMed.Text = " "

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim con = New MySqlConnection
        con.ConnectionString = "server=localhost; user id =root; password= ; database=gestionhospital;"
        Dim READER As MySqlDataReader
        Dim soa As New MySqlDataAdapter
        Dim dataset As New DataTable

        Dim source As New BindingSource

        Try
            con.Open()

            Dim query As String
            query = "insert into gestionhospital.malade(CodeMalade,NomMalade,PrenomMalade,AdresseMalade,Mutuelle,Numtel)values('" & TextBox1.Text & "','" & TextBox7.Text & "','" & TextBox6.Text & "','" & TextBox5.Text & "','" & TextBox4.Text & "','" & TextBox4.Text & "')"
            command = New MySqlCommand(query, con)
            READER = command.ExecuteReader
            MessageBox.Show("malade enregistre")
            soa.SelectCommand = command
            soa.Fill(dataset)
            source.DataSource = dataset
            Dgvmalade.DataSource = source
            soa.Update(dataset)
            Dgvmalade.Refresh()
            Form1_Load(sender, e)
        Catch ex As Exception
            con.Close()
        Finally
            con.Dispose()

        End Try
        Dgvmalade.Refresh()

        loadtable()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Form1_Load(sender, e)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form1_Load(sender, e)
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Dim con = New MySqlConnection
        con.ConnectionString = "server=localhost; user id =root; password= ; database=gestionhospital;"
        Dim READER As MySqlDataReader
        Dim soa As New MySqlDataAdapter
        Dim dataset As New DataTable

        Dim source As New BindingSource

        Try
            con.Open()
            Dim query As String
            query = "insert into gestionhospital.service(CodeService,code,NomService,Batiment)values('" & TextBox2.Text & "','" & TextBox10.Text & "','" & TextBox9.Text & "','" & TextBox8.Text & "')"
            command = New MySqlCommand(query, con)
            READER = command.ExecuteReader
            MessageBox.Show("service sauvegarde")
            soa.SelectCommand = command
            soa.Fill(dataset)
            source.DataSource = dataset
            Dgvservice.DataSource = source
            soa.Update(dataset)
            Dgvservice.Refresh()
            Form1_Load(sender, e)
        Catch ex As Exception
            con.Close()
        Finally
            con.Dispose()

        End Try
        Dgvservice.Refresh()

        loadtable()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Form1_Load(sender, e)
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Dim con = New MySqlConnection
        con.ConnectionString = "server=localhost; user id =root; password= ; database=gestionhospital;"
        Dim READER As MySqlDataReader
        Dim soa As New MySqlDataAdapter
        Dim dataset As New DataTable

        Dim source As New BindingSource

        Try
            con.Open()
            Dim query As String
            query = "insert into gestionhospital.batiment(NumBatiment,NomBatiment,CodeService)values('" & TextBox11.Text & "','" & TextBox12.Text & "','" & TextBox13.Text & "')"
            command = New MySqlCommand(query, con)
            READER = command.ExecuteReader
            MessageBox.Show("BATIMENT AJOUTE")
            soa.SelectCommand = command
            soa.Fill(dataset)
            source.DataSource = dataset
            Dgvbatiment.DataSource = source
            soa.Update(dataset)
            Dgvbatiment.Refresh()
            Form1_Load(sender, e)
        Catch ex As Exception
            con.Close()
        Finally
            con.Dispose()

        End Try
        Dgvbatiment.Refresh()


    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        Form1_Load(sender, e)
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles ajouter.Click
        Dim con = New MySqlConnection
        con.ConnectionString = "server=localhost; user id =root; password= ; database=gestionhospital;"
        Dim READER As MySqlDataReader
        Dim soa As New MySqlDataAdapter
        Dim dataset As New DataTable

        Dim source As New BindingSource

        Try
            con.Open()
            Dim query As String
            query = "insert into gestionhospital.hospitalisation(NumSalle,CodeMalade,NumHospitalisation,Diagnostic,DateHospitalisation,NomMalade)values('" & TextBox14.Text & "','" & TextBox15.Text & "','" & TextBox18.Text & "','" & TextBox17.Text & "','" & datehosp.Text & "','" & ComboBox1.Text & "')"
            command = New MySqlCommand(query, con)
            READER = command.ExecuteReader
            MessageBox.Show("HOSPITALISATION EFFECTUEE")
            soa.SelectCommand = command
            soa.Fill(dataset)
            source.DataSource = dataset
            Dgvhos.DataSource = source
            soa.Update(dataset)
            Dgvhos.Refresh()
            Form1_Load(sender, e)
        Catch ex As Exception
            con.Close()
        Finally
            con.Dispose()

        End Try
        Dgvhos.Refresh()

    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        Form1_Load(sender, e)
        Dgvhos.Refresh()

    End Sub

    Private Sub ajoutesalle_Click(sender As Object, e As EventArgs) Handles ajoutesalle.Click
        Dim con = New MySqlConnection
        con.ConnectionString = "server=localhost; user id =root; password= ; database=gestionhospital;"
        Dim READER As MySqlDataReader
        Dim soa As New MySqlDataAdapter
        Dim dataset As New DataTable

        Dim source As New BindingSource

        Try
            con.Open()
            Dim query As String
            query = "insert into gestionhospital.salle(NumSalle,NumBatiment,CodeInfirmier,NbreDeLit,NumDeDebut,NumDeFin)values('" & TextBox16.Text & "','" & TextBox23.Text & "','" & TextBox22.Text & "','" & TextBox21.Text & "','" & TextBox20.Text & "','" & TextBox19.Text & "')"
            command = New MySqlCommand(query, con)
            READER = command.ExecuteReader
            MessageBox.Show("choix Salle  EFFECTUEE")
            soa.SelectCommand = command
            soa.Fill(dataset)
            source.DataSource = dataset
            dgvsalle.DataSource = source
            soa.Update(dataset)
            dgvsalle.Refresh()
            Form1_Load(sender, e)
        Catch ex As Exception
            con.Close()
        Finally
            con.Dispose()

        End Try
        dgvsalle.Refresh()

    End Sub

    Private Sub Button26_Click(sender As Object, e As EventArgs) Handles Button26.Click
        Form1_Load(sender, e)

    End Sub

    Private Sub Dgvhospi_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub Button22_Click(sender As Object, e As EventArgs) Handles Button22.Click

        Dim con = New MySqlConnection
        con.ConnectionString = "server=localhost; user id =root; password= ; database=gestionhospital;"
        Dim READER As MySqlDataReader
        Dim soa As New MySqlDataAdapter
        Dim dataset As New DataTable

        Dim source As New BindingSource

        Try
            con.Open()
            Dim query As String
            query = "Delete from gestionhospital.medecin where  code ='" & codeMed.Text & "'"
            command = New MySqlCommand(query, con)
            READER = command.ExecuteReader
            MessageBox.Show("medecin supprimé")

            Form1_Load(sender, e)
            Dgvmedecin.Refresh()

        Catch ex As Exception
            con.Close()
        Finally
            con.Dispose()

        End Try
        Dgvmedecin.Refresh()



    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        Dim con = New MySqlConnection
        con.ConnectionString = "server=localhost; user id =root; password= ; database=gestionhospital;"
        Dim READER As MySqlDataReader
        Try
            con.Open()
            Dim query As String
            query = "UPDATE  gestionhospital.infirmier SET CodeService= '" & Codeservice.Text & " ',CodeInfirmier='" & codeinfirmie.Text & "',Numtel='" & NumInf.Text & "',Salaire='" & salaire.Text & "',Horaire='" & horaire.Text & "',NomInf='" & NomInf.Text & "',PrenomInf='" & PrenomInf.Text & "',AdresseInf='" & AdresseInf.Text & "' where CodeInfirmier='" & codeinfirmie.Text & "'"
            command = New MySqlCommand(query, con)
            READER = command.ExecuteReader
            MessageBox.Show("Infirmier mise a jour")

            Form1_Load(sender, e)
            DgvInfirmmier.Refresh()
        Catch ex As Exception
            con.Close()
        Finally
            con.Dispose()
        End Try
    End Sub

    Private Sub Button21_Click(sender As Object, e As EventArgs) Handles Button21.Click
        Dim con = New MySqlConnection
        con.ConnectionString = "server=localhost; user id =root; password= ; database=gestionhospital;"
        Dim READER As MySqlDataReader
        Dim soa As New MySqlDataAdapter
        Dim dataset As New DataTable

        Dim source As New BindingSource

        Try
            con.Open()
            Dim query As String
            query = "Delete from gestionhospital.infirmier where  CodeInfirmier ='" & codeinfirmie.Text & "'"
            command = New MySqlCommand(query, con)
            READER = command.ExecuteReader
            MessageBox.Show("Infirmier supprimé")

            Form1_Load(sender, e)
            DgvInfirmmier.Refresh()

        Catch ex As Exception
            con.Close()
        Finally
            con.Dispose()

        End Try
        DgvInfirmmier.Refresh()


    End Sub

    Private Sub Button25_Click(sender As Object, e As EventArgs) Handles Button25.Click
        Codeservice.Text = ""
        codeinfirmie.Text = ""
        NumInf.Text = ""
        salaire.Text = ""
        horaire.Text = ""
        NomInf.Text = ""
        PrenomInf.Text = ""
        AdressMed.Text = ""

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim con = New MySqlConnection
        con.ConnectionString = "server=localhost; user id =root; password= ; database=gestionhospital;"
        Dim READER As MySqlDataReader
        Try
            con.Open()
            Dim query As String
            query = "UPDATE  gestionhospital.malade SET CodeMalade= '" & TextBox1.Text & " ',NomMalade='" & TextBox7.Text & "',PrenomMalade='" & TextBox6.Text & "',AdresseMalade='" & TextBox5.Text & "',Mutuelle='" & TextBox4.Text & "',Numtel='" & TextBox3.Text & "'where CodeMalade='" & TextBox1.Text & "'"
            command = New MySqlCommand(query, con)
            READER = command.ExecuteReader
            MessageBox.Show("Malade mise a jour")

            Form1_Load(sender, e)
            Dgvmalade.Refresh()
        Catch ex As Exception
            con.Close()
        Finally
            con.Dispose()
        End Try
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim con = New MySqlConnection
        con.ConnectionString = "server=localhost; user id =root; password= ; database=gestionhospital;"
        Dim READER As MySqlDataReader
        Dim soa As New MySqlDataAdapter
        Dim dataset As New DataTable

        Dim source As New BindingSource

        Try
            con.Open()
            Dim query As String
            query = "Delete from gestionhospital.malade where  CodeMalade ='" & TextBox1.Text & "'"
            command = New MySqlCommand(query, con)
            READER = command.ExecuteReader
            MessageBox.Show("Malade supprimé")

            Form1_Load(sender, e)
            Dgvmalade.Refresh()

        Catch ex As Exception
            con.Close()
        Finally
            con.Dispose()

        End Try
        Dgvmalade.Refresh()

    End Sub

    Private Sub Button27_Click(sender As Object, e As EventArgs) Handles Button27.Click
        TextBox1.Text = ""
        TextBox7.Text = ""
        TextBox6.Text = ""
        TextBox5.Text = ""
        TextBox4.Text = ""
        TextBox3.Text = ""

    End Sub

    Private Sub Button29_Click(sender As Object, e As EventArgs) Handles Button29.Click
        Dim con = New MySqlConnection
        con.ConnectionString = "server=localhost; user id =root; password= ; database=gestionhospital;"
        Dim READER As MySqlDataReader
        Try
            con.Open()
            Dim query As String
            query = "UPDATE  gestionhospital.service SET CodeService= '" & TextBox2.Text & " ',code='" & TextBox10.Text & "',NomService='" & TextBox9.Text & "',Batiment='" & TextBox8.Text & "'where CodeService='" & TextBox2.Text & "'"
            command = New MySqlCommand(query, con)
            READER = command.ExecuteReader
            MessageBox.Show("Service mise a jour")

            Form1_Load(sender, e)
            Dgvservice.Refresh()
        Catch ex As Exception
            con.Close()
        Finally
            con.Dispose()
        End Try
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Dim con = New MySqlConnection
        con.ConnectionString = "server=localhost; user id =root; password= ; database=gestionhospital;"
        Dim READER As MySqlDataReader
        Dim soa As New MySqlDataAdapter
        Dim dataset As New DataTable

        Dim source As New BindingSource

        Try
            con.Open()
            Dim query As String
            query = "Delete from gestionhospital.service where  CodeService ='" & TextBox2.Text & "'"
            command = New MySqlCommand(query, con)
            READER = command.ExecuteReader
            MessageBox.Show("service supprimé")

            Form1_Load(sender, e)
            Dgvservice.Refresh()

        Catch ex As Exception
            con.Close()
        Finally
            con.Dispose()

        End Try
        Dgvservice.Refresh()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        TextBox2.Text = ""
        TextBox10.Text = ""
        TextBox9.Text = ""
        TextBox8.Text = ""
        MsgBox("formulaire liberé")

    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        TextBox11.Text = ""
        TextBox12.Text = ""
        TextBox13.Text = ""

    End Sub

    Private Sub Button28_Click(sender As Object, e As EventArgs) Handles Button28.Click
        Dim con = New MySqlConnection
        con.ConnectionString = "server=localhost; user id =root; password= ; database=gestionhospital;"
        Dim READER As MySqlDataReader
        Dim soa As New MySqlDataAdapter
        Dim dataset As New DataTable

        Dim source As New BindingSource

        Try
            con.Open()
            Dim query As String
            query = "Delete from gestionhospital.batiment where  NumBatiment ='" & TextBox11.Text & "'"
            command = New MySqlCommand(query, con)
            READER = command.ExecuteReader
            MessageBox.Show("batiment detruit")

            Form1_Load(sender, e)
            Dgvbatiment.Refresh()

        Catch ex As Exception
            con.Close()
        Finally
            con.Dispose()

        End Try
        Dgvbatiment.Refresh()
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        Dim con = New MySqlConnection
        con.ConnectionString = "server=localhost; user id =root; password= ; database=gestionhospital;"
        Dim READER As MySqlDataReader
        Try
            con.Open()
            Dim query As String
            query = "UPDATE  gestionhospital.batiment SET NumBatiment= '" & TextBox11.Text & " ',NomBatiment='" & TextBox12.Text & "',CodeService='" & TextBox13.Text & "'where NumBatiment='" & TextBox11.Text & "'"
            command = New MySqlCommand(query, con)
            READER = command.ExecuteReader
            MessageBox.Show("Batiment Actualise")

            Form1_Load(sender, e)
            Dgvbatiment.Refresh()
        Catch ex As Exception
            con.Close()
        Finally
            con.Dispose()
        End Try
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        Dim con = New MySqlConnection
        con.ConnectionString = "server=localhost; user id =root; password= ; database=gestionhospital;"
        Dim READER As MySqlDataReader
        Dim soa As New MySqlDataAdapter
        Dim dataset As New DataTable

        Dim source As New BindingSource

        Try
            con.Open()
            Dim query As String
            query = "Delete from gestionhospital.hospitalisation where  NumHospitalisation ='" & TextBox18.Text & "'"
            command = New MySqlCommand(query, con)
            READER = command.ExecuteReader
            MessageBox.Show("Hospitalisation supprimée")

            Form1_Load(sender, e)
            Dgvhos.Refresh()

        Catch ex As Exception
            con.Close()
        Finally
            con.Dispose()

        End Try
        Dgvhos.Refresh()
    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        Dim con = New MySqlConnection
        con.ConnectionString = "server=localhost; user id =root; password= ; database=gestionhospital;"
        Dim READER As MySqlDataReader
        Try
            con.Open()
            Dim query As String
            query = "UPDATE  gestionhospital.hospitalisation SET NumSalle= '" & TextBox14.Text & " ',CodeMalade='" & TextBox15.Text & "',NumHospitalisation='" & TextBox18.Text & "',Diagnostic='" & TextBox17.Text & "',DateHospitalisation='" & datehosp.Text & "'where NumHospitalisation='" & TextBox18.Text & "'"
            command = New MySqlCommand(query, con)
            READER = command.ExecuteReader
            MessageBox.Show("Actualisation de l' Hospitalisation")

            Form1_Load(sender, e)
            Dgvhos.Refresh()
        Catch ex As Exception
            con.Close()
        Finally
            con.Dispose()
        End Try
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        TextBox14.Text = ""
        TextBox15.Text = ""
        TextBox18.Text = ""
        TextBox17.Text = ""


    End Sub

    Private Sub Button23_Click(sender As Object, e As EventArgs) Handles Button23.Click
        choixservice.Show()
        Me.Hide()

    End Sub

    Private Sub Button30_Click(sender As Object, e As EventArgs) Handles Button30.Click
        Dim con = New MySqlConnection
        con.ConnectionString = "server=localhost; user id =root; password= ; database=gestionhospital;"
        Dim READER As MySqlDataReader
        Dim soa As New MySqlDataAdapter
        Dim dataset As New DataTable

        Dim source As New BindingSource

        Try
            con.Open()
            Dim query As String
            query = "Delete from gestionhospital.salle where  NumSalle ='" & TextBox16.Text & "'"
            command = New MySqlCommand(query, con)
            READER = command.ExecuteReader
            MessageBox.Show("Salle supprimée")

            Form1_Load(sender, e)
            dgvsalle.Refresh()

        Catch ex As Exception
            con.Close()
        Finally
            con.Dispose()

        End Try
        dgvsalle.Refresh()
    End Sub

    Private Sub Button24_Click(sender As Object, e As EventArgs) Handles Button24.Click
        Dim con = New MySqlConnection
        con.ConnectionString = "server=localhost; user id =root; password= ; database=gestionhospital;"
        Dim READER As MySqlDataReader
        Try
            con.Open()
            Dim query As String
            query = "UPDATE  gestionhospital.salle SET NumSalle= '" & TextBox16.Text & " ',Numbatiment='" & TextBox23.Text & "',CodeInfirmier='" & TextBox22.Text & "',NbreDeLit='" & TextBox21.Text & "',NumDeDebut='" & TextBox20.Text & "',NumDeFin='" & TextBox19.Text & "'where NumSalle='" & TextBox16.Text & "'"
            command = New MySqlCommand(query, con)
            READER = command.ExecuteReader
            MessageBox.Show("Actualisation de la Salle")

            Form1_Load(sender, e)
            dgvsalle.Refresh()
        Catch ex As Exception
            con.Close()
        Finally
            con.Dispose()
        End Try
    End Sub

    Private Sub Button12_Click_1(sender As Object, e As EventArgs) Handles Button12.Click
        TextBox16.Text = ""
        TextBox23.Text = ""
        TextBox22.Text = ""
        TextBox21.Text = ""
        TextBox20.Text = ""
        TextBox19.Text = ""
        MsgBox("formulaire effacé")

    End Sub

    Private Sub TextBox24_TextChanged(sender As Object, e As EventArgs) Handles TextBox24.TextChanged
        dv.DefaultView.RowFilter = "NomMedecin Like'%" & TextBox24.Text & "%'"

    End Sub

    Private Sub TextBox25_TextChanged(sender As Object, e As EventArgs) Handles TextBox25.TextChanged
        di.DefaultView.RowFilter = "NomInf Like'%" & TextBox25.Text & "%'"
    End Sub




    Private Sub Button31_Click(sender As Object, e As EventArgs)
        'boite de prévisualisation
        Dim ppd As New PrintPreviewDialog
        'document à imprimer
        Dim doc As New PrintDocument
        'nom pour le gestionnaire d'imprimante
        doc.DocumentName = "MaForm"
        'abonnement à l'événement PrintPage
        AddHandler doc.PrintPage, AddressOf Impression
        'paramètres de page
        Dim ps As New PageSettings
        'ici en paysage pour l'exemple
        ps.Landscape = True
        doc.DefaultPageSettings = ps
        'indique à la prévisualisation le document à montrer
        ppd.Document = doc
        'previsualisation plein écran
        ppd.WindowState = FormWindowState.Maximized
        'imprssion si ok
        If ppd.ShowDialog = Windows.Forms.DialogResult.OK Then
            ppd.Document.Print()
        End If
    End Sub

    'c'est ici que l'on dessine quoi imprimer
    'dans ton cas on à besoin de créer un bitmap vierge pour y peindre ton formulaire par la méthode rapide DrawToBitmap
    Private Sub Impression(ByVal sender As Object, ByVal e As PrintPageEventArgs)
        'déclaration du nouveau bitmap
        Dim b As New Bitmap(Me.Width, Me.Height)
        'dessin du formulaire sur le bitmap
        Me.DrawToBitmap(b, Me.Bounds)
        'dessin avec Graphics 
        e.Graphics.DrawImage(b, 0, 0, b.Width, b.Height)
        'indique qu'il n'y a qu'une page à imprimer
        e.HasMorePages = False
    End Sub

    Private Sub Button32_Click(sender As Object, e As EventArgs)
        'boite de prévisualisation
        Dim ppd As New PrintPreviewDialog
        'document à imprimer
        Dim doc As New PrintDocument
        'nom pour le gestionnaire d'imprimante
        doc.DocumentName = "MaForm"
        'abonnement à l'événement PrintPage
        AddHandler doc.PrintPage, AddressOf Impression
        'paramètres de page
        Dim ps As New PageSettings
        'ici en paysage pour l'exemple
        ps.Landscape = True
        doc.DefaultPageSettings = ps
        'indique à la prévisualisation le document à montrer
        ppd.Document = doc
        'previsualisation plein écran
        ppd.WindowState = FormWindowState.Maximized
        'imprssion si ok
        If ppd.ShowDialog = Windows.Forms.DialogResult.OK Then
            ppd.Document.Print()
        End If
    End Sub

    Private Sub TextBox26_TextChanged(sender As Object, e As EventArgs) Handles TextBox26.TextChanged
        dm.DefaultView.RowFilter = "NomMalade Like'%" & TextBox26.Text & "%'"
    End Sub


    Private Sub TextBox27_TextChanged(sender As Object, e As EventArgs) Handles TextBox27.TextChanged
        ds.DefaultView.RowFilter = "NomService Like'%" & TextBox27.Text & "%'"
    End Sub

    Private Sub TextBox28_TextChanged(sender As Object, e As EventArgs) Handles TextBox28.TextChanged
        db.DefaultView.RowFilter = "Nombatiment Like'%" & TextBox28.Text & "%'"
    End Sub

    Private Sub TextBox29_TextChanged(sender As Object, e As EventArgs) Handles TextBox29.TextChanged
        dsa.DefaultView.RowFilter = "Diagnostic  Like'%" & TextBox29.Text & "%'"
    End Sub


    Private Sub TextBox30_TextChanged(sender As Object, e As EventArgs) Handles TextBox30.TextChanged

        Try

            dsal.DefaultView.RowFilter = "NumSalle Like  '%" & TextBox30.Text & "%'"
        Catch ep As System.Data.EvaluateException

        End Try

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Button33_Click(sender As Object, e As EventArgs) Handles Button33.Click
        choixservice.Show()
        Me.Hide()

    End Sub

    Private Sub Dgvmalade_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Dgvmalade.CellContentClick
        TextBox1.Text = Dgvmalade.Rows(ligne).Cells(0).Value
        TextBox7.Text = Dgvmalade.Rows(ligne).Cells(1).Value
        TextBox6.Text = Dgvmalade.Rows(ligne).Cells(2).Value
        TextBox5.Text = Dgvmalade.Rows(ligne).Cells(3).Value
        TextBox4.Text = Dgvmalade.Rows(ligne).Cells(4).Value
        TextBox3.Text = Dgvmalade.Rows(ligne).Cells(5).Value
        nomMed.Text = Dgvmedecin.Rows(ligne).Cells(1).Value

    End Sub
    Public Sub Dgvmalade_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Dgvmalade.MouseUp
        ligne = Dgvmalade.HitTest(e.X, e.Y).RowIndex
        If ligne >= 0 Then
            Dgvmalade.Rows(ligne).Selected = True
        End If
    End Sub
    Public Sub Dgvmedecin_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Dgvmedecin.MouseUp
        ligne = Dgvmedecin.HitTest(e.X, e.Y).RowIndex
        If ligne >= 0 Then
            Dgvmedecin.Rows(ligne).Selected = True
        End If
    End Sub


    Private Sub Button34_Click(sender As Object, e As EventArgs) Handles Button34.Click
        formsuivie.Show()
        Me.Hide()

    End Sub

    Private Sub TabPage5_Click(sender As Object, e As EventArgs) Handles TabPage5.Click

    End Sub

   
   
    Private Sub TextBox19_TextChanged(sender As Object, e As EventArgs) Handles TextBox19.TextChanged

    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click

    End Sub

    Private Sub Button37_Click(sender As Object, e As EventArgs) Handles Button37.Click
        choixservice.Show()
        Me.Hide()
    End Sub

    Private Sub Button36_Click(sender As Object, e As EventArgs) Handles Button36.Click
        choixservice.Show()
        Me.Hide()
    End Sub

    Private Sub Button35_Click(sender As Object, e As EventArgs) Handles Button35.Click
        choixservice.Show()
        Me.Hide()
    End Sub

    Private Sub Button32_Click_1(sender As Object, e As EventArgs) Handles Button32.Click
        choixservice.Show()
        Me.Hide()
    End Sub

    Private Sub Button31_Click_1(sender As Object, e As EventArgs) Handles Button31.Click
        choixservice.Show()
        Me.Hide()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub
End Class

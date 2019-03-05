Imports System.Data.SqlClient

Public Class Persistance


    'classe avec des méthode de classe 
    '

    'pas besoin de constructeur 

    Public Shared Sub versBddCredit() '' c'est une methode de classe, en c#, java = static
        'connexion a la base de données

        'Toute les instructions / commande associé 
        Dim strConnexion As String = "Data Source=10.129.187.128;User Id=connVelez;password=mdpVelez16V1;Initial Catalog=Crédit_Celeste_VELEZ"

        Dim strRequete As String = "SELECT MontantFinance, NombreMensualites, MontantMensualites, TauxAnnuel FROM CREDIT WHERE ClientCredit='VELEZ'"

        'Simple cote pour sql

        ' Connexion a la bdd avec une creation d'un objet Connexion
        Dim oConnexion As SqlConnection = New SqlConnection(strConnexion)

        ' lancer la commande 

        Dim oCommand As SqlCommand = New SqlCommand(strRequete, oConnexion)


        'Dim i As Integer = 0
        ''Pour le nom du client en dur
        'Dim NomClient As String = "VELEZ"
        'Dim monMontantFinance As Double = txtCapital.Text
        'Dim monNombreMensualites As Integer = txtDuree.Text
        'Dim monMontantMensualites As Double = txtMensualite.Text
        'Dim monTauxAnnuel As Integer = txtTaux.Text

        'Try

        '    'ajouter un enregistrement
        '    'meme que str connexion
        '    Dim cnn As SqlConnection = New SqlConnection("Data Source=172.16.12.99;User Id=connEleveSio;password=mdpEleveSio;Initial Catalog=KREYDER-CreditCeleste")

        '    'cnn.Open()

        '    Dim sql As String = "insert into CREDIT(MontantFinance, NombreMensualites, MontantMensualites, TauxAnnuel, ClientCredit) VALUES ('"
        '    sql &= Str(monMontantFinance) & "', '" & monNombreMensualites & "', '" & Str(monMontantMensualites) & "', '" & monTauxAnnuel & "', '" & NomClient & "')"

        '    'todo yv

        '    Dim cmd As New SqlCommand(sql, cnn)

        '    lblConnexion.Text = "Connecté"

        '    cnn.Open()
        '    cmd.ExecuteNonQuery()
        '    cnn.Close()


        '    '-------------------------
        '    'On deverse l'adapteur dans la table de la bdd local
        '    ' oAdapteur.Fill(oDSCred, "Credit")

        '    'Rows=ligne     / Rows(0)(0) ligne 0 et colone 0
        '    'txtNom.Text = oDSCred.Tables("Elv").Rows(0)(0)
        '    'txtPrenom.Text = oDSCred.Tables(0).Rows(0)("prenomVendeur")

        '    'txtCapital.Text = oDSCred.Tables("Credit").Rows(0)("montantFinance")(0)(0)(0)(0)(0)
        '    'txtTaux.Text = oDSCred.Tables("Credit").Rows(0)(0)("NombreMensualite")(0)(0)(0)(0)
        '    'txtDuree.Text = oDSCred.Tables("Credit").Rows(0)(0)(0)("MontantMensualite")(0)(0)(0)
        '    'txtMensualite.Text = oDSCred.Tables("Credit").Rows(0)(0)(0)(0)("TauxAnnuel")(0)



        '    'Si il ya aune erreur

        'Catch ex As Exception

        '    lblConnexion.Text = "Erreur"

        '    MsgBox("Erreur " + ex.Message)
        'End Try
    End Sub


    Public Shared Sub depuisBddCredit()

    End Sub

    Public Shared Sub depuisBddVendeur()
        'récuperre les vendeurs depuis la bdd pour les mettres dans l'écran Accueil

        'Toute les instructions / commande associé 
        Dim strConnexion As String = "Data Source=10.129.187.128;User Id=connVelez;password=mdpVelez16V1;Initial Catalog=Crédit_Celeste_VELEZ"

        Dim strRequete As String = "SELECT  cidtVendeur, nomVendeur, prenomVendeur FROM VENDEUR "

        '
        ' Connexion a la bdd avec une creation d'un objet Connexion
        Dim oConnexion As SqlConnection = New SqlConnection(strConnexion)

        ' lancer la commande 

        Dim oCommand As SqlCommand = New SqlCommand(strRequete, oConnexion)



        Try
            oConnexion.Open()

        Catch
            MsgBox("Erreur de connexion bdd")

        End Try

        Dim oReader As SqlDataReader = oCommand.ExecuteReader

        While oReader.Read()
            Dim unVendeur As New Vendeur(Trim(oReader.GetString(0)), oReader.GetString(1), oReader.GetString(2))

            ' Dim numVend As New Vendeur(Trim(oReader.GetString(0)))

            uneConcession.lesVendeurs.Add(unVendeur)

        End While



    End Sub




End Class

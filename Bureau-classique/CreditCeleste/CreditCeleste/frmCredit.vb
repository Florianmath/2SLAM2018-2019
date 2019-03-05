Imports System.Data.SqlClient
'Pour les sql...

Public Class frmCredit
    Private Sub frmCredit_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' affichage du credit
        '
        'lire les credit des clients
        '


        txtCapital.Text = unCredit.getMonCapitale
        txtDuree.Text = unCredit.getMaDuree
        txtTaux.Text = unCredit.getMonTaux
        txtMensualite.Text = unCredit.getMaMensualite


        'todo ak


        lblVendeur.Text = unVendeur.getVendeur


    End Sub

    Private Sub cmdValide_Click(sender As Object, e As EventArgs) Handles cmdValide.Click

        Dim unCredit As Credit = New Credit(Convert.ToDouble(txtTaux.Text), Convert.ToDouble(txtDuree.Text), Convert.ToDouble(txtCapital.Text))
        'todo yv a changer un seul credit
        'Convert.ToDouble(txtMensualite.Text) = unCredit.mensualites()

        txtMensualite.Text = unCredit.mensualites()
        'Si la fentre est vide 
        If txtMensualite.Text <> 0 Then
            Convert.ToDouble(txtMensualite.Text)
        End If
        'Pour enregistrer
        'unCredit.setEnregistreCredit(txtCapital.Text, txtTaux.Text, txtDuree.Text, txtMensualite.Text)

        'MsgBox("")
    End Sub

    Private Sub cmdIntroduction_Click(sender As Object, e As EventArgs) Handles cmdIntroduction.Click

        If fenIntro Is Nothing Then 'si fentre existe pas la crée
            fenIntro = New frmIntroduction  'desing pattern : singleton
        ElseIf fenIntro.IsDisposed Then 'si disposé, il le crée a nouveau
            fenIntro = New frmIntroduction
        End If

        fenIntro.Show()  ' affichage de l'objet

        'fenIntro.ShowDialog() 'forcer la saisie / fentre modale
        fenIntro.BringToFront()   'pour le mettre en 1er plan 


        'Me.Hide() ' pour masquer la fentre active
        Me.Close()
    End Sub

    Private Sub cmdCredit_Click(sender As Object, e As EventArgs)
        If fenCredit Is Nothing Then
            fenCredit = New frmCredit  'desing pattern : singleton
        ElseIf fenCredit.IsDisposed Then
            fenCredit = New frmCredit
        End If

        fenCredit.Show()  ' affichage de l'objet

        'fenIntro.ShowDialog() 'forcer la saisie / fentre modale
        fenCredit.BringToFront()   'pour le mettre en 1er plan 


        'Me.Hide() ' pour masquer la fentre active mais ne repasse pas dans le formload
        Me.Close()

    End Sub

    Private Sub cmdVoiture_Click(sender As Object, e As EventArgs) Handles cmdVoiture.Click
        ' mettre en place la fenetre du crédit
        '
        'Le tout en c# (écran et la classe voiture)
        'l'écran e, vb et la classe est en c#


        If fenSaisie Is Nothing Then
            fenSaisie = New frmSaisieBien  'desing pattern : singleton
        ElseIf fenSaisie.IsDisposed Then
            fenSaisie = New frmSaisieBien
        End If

        fenSaisie.Show()  ' affichage de l'objet

        fenSaisie.BringToFront()   'pour le mettre en 1er plan 



        'Me.Hide() ' pour masquer la fentre active mais ne repasse pas dans le formload
        Me.Close()

    End Sub

    Private Sub cmdEnr_Click(sender As Object, e As EventArgs) Handles cmdEnr.Click



        unCredit.setCapitale(txtCapital.Text)
        unCredit.setTaux(txtTaux.Text)
        unCredit.setDuree(txtDuree.Text)
        unCredit.setMensualite(txtMensualite.Text)

        'Pour enregistrer le credit en un seul coût
        'unCredit.setEnregistreCredit(txtTaux.Text, txtCapital.Text, txtDuree.Text, txtMensualite.Text)


        unCredit.setEnregistreVente(lblVendeur.Text, txtTaux.Text, txtCapital.Text, txtDuree.Text, txtMensualite.Text)

        MsgBox("ok")
    End Sub

    Private Sub cmdConnexion_Click(sender As Object, e As EventArgs) Handles cmdConnexion.Click


        'utilisation d'une classe de persistance 

        Persistance.versBddCredit()


    End Sub



    Private Sub cmdClient_Click(sender As Object, e As EventArgs) Handles cmdClient.Click
        'affichage du client

        If fenCoordClient Is Nothing Then
            fenCoordClient = New frmCoordonnéesClient  'desing pattern : singleton
        ElseIf fenCoordClient.IsDisposed Then 'si disposé, il le crée a nouveau
            fenCoordClient = New frmCoordonnéesClient
        End If

        fenCoordClient.Show()  ' affichage de l'objet

        'fenIntro.ShowDialog() 'forcer la saisie / fentre modale
        fenCoordClient.BringToFront()   'pour le mettre en 1er plan 


        'Me.Hide() ' pour masquer la fentre active
        Me.Close()

    End Sub
End Class
Public Class frmCoordonnéesClient
    Private Sub cmdEnr_Click(sender As Object, e As EventArgs) Handles cmdEnr.Click

        'If frmCoordonnéesClient.ControlAccessibleObject As TextBox  Then 
        ' si c'est un textbox
        'il faut regarder si il est vide
        'se positionner dessus (anciennement setfocus)

        ' While // ou for pour mettre toutes les erreurs en rouge

        ' End If

        'For Each txt As TextBox In Me.Controls
        '    If txt.Text = "" Then
        '        MsgBox("la textbox est vide")
        '        txt.Text = Focus()
        '    End If
        'Next


        '
        'client de base ( ceux qui s'applique aux 2)
        '
        unClientVoit.setCidtClient(cboCidt.Text)
        unClientVoit.setNomClient(txtNom.Text)
        unClientVoit.setPrenomClient(txtPrenom.Text)
        unClientVoit.setAdresseMailClient(txtAdresseMail.Text)
        '
        'generique
        '
        unClientVoit.setAdresseClient(txtAdresse.Text)
        unClientGenerique.setCodePostal(txtCP.Text)
        unClientGenerique.Ville = txtVille.Text
        unClientGenerique.Telephone = txtTel.Text
        '
        'Specifique
        '
        unClientSpecifique.setDateDeNaissance(txtDateDeNaissnace.Text)
        unClientSpecifique.setRevenuAnnuel(txtRevenuAnnuel.Text)
        '
        unClientSpecifique.maProfession = txtProfession.Text
        unClientSpecifique.monNomDeJeunneFille = txtNomDeJeunneFille.Text

        MsgBox("Données enregistrée(s)")

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

    Private Sub cmdCredit_Click(sender As Object, e As EventArgs) Handles cmdCredit.Click

        'affichage du bien 

        If fenCredit Is Nothing Then
            fenCredit = New frmCredit  'desing pattern : singleton
        ElseIf fenCredit.IsDisposed Then 'si disposé, il le crée a nouveau
            fenCredit = New frmCredit
        End If

        fenCredit.Show()  ' affichage de l'objet

        'fenIntro.ShowDialog() 'forcer la saisie / fentre modale
        fenCredit.BringToFront()   'pour le mettre en 1er plan 


        'Me.Hide() ' pour masquer la fentre active
        Me.Close()
    End Sub

    Private Sub frmCoordonnéesClient_Load(sender As Object, e As EventArgs) Handles MyBase.Load



        txtNom.Text = unClientVoit.getNomClient()
        txtPrenom.Text = unClientVoit.getPrenomClient()
        cboCidt.Text = unClientVoit.getCidtClient()
        txtAdresseMail.Text = unClientVoit.getAdresseMailClient()
        '
        txtAdresse.Text = unClientVoit.getAdresseClient()
        txtCP.Text = unClientGenerique.getmonCodePostal()
        txtVille.Text = unClientGenerique.Ville()
        txtTel.Text = unClientGenerique.Telephone()
        '
        txtDateDeNaissnace.Text = unClientSpecifique.getMaDateDeNaissance()
        txtRevenuAnnuel.Text = unClientSpecifique.getMonRevenuAnnuel()
        '
        txtProfession.Text = unClientSpecifique.maProfession()
        txtNomDeJeunneFille.Text = unClientSpecifique.monNomDeJeunneFille()



    End Sub
End Class
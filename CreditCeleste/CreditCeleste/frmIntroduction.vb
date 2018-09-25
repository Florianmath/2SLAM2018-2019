﻿Public Class frmIntroduction
    Private Sub frmIntroduction_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' affichage des vendeurs
        '
        'lire les vendeurs de la concesssion
        '

        For Each xVendeur As Vendeur In uneConcession.lesVendeurs
            cboVendeur.Items.Add(xVendeur.getVendeur)
        Next

        'de l'objet vers l'écran pour la voiture

        txtNouvVeh.Text = uneVoiture.getNomVehicule()
        txtAncVeh.Text = uneVoiture.getNomAncienVehicule() '''' faux ======

        'gestion de l'age du véhicule



        'changer le client, de l'objet vers l'écran

        txtNom.Text = unClientVoit.getNomClient()
        txtPrenom.Text = unClientVoit.getPrenomClient()
        cboCidt.Text = unClientVoit.getCidtClient()


    End Sub

    Private Sub gpbAge_Enter(sender As Object, e As EventArgs) Handles gpbAge.Enter

    End Sub

    Private Sub rdbNeuf_CheckedChanged(sender As Object, e As EventArgs) Handles rdbNeuf.CheckedChanged

    End Sub

    Private Sub rdbOcc3_CheckedChanged(sender As Object, e As EventArgs) Handles rdbOcc3.CheckedChanged

    End Sub

    Private Sub rdb3a5_CheckedChanged(sender As Object, e As EventArgs) Handles rdbOcc3a5.CheckedChanged

    End Sub

    Private Sub rdbOcc5_CheckedChanged(sender As Object, e As EventArgs) Handles rdbOcc5.CheckedChanged

    End Sub

    Private Sub txtNouvVeh_TextChanged(sender As Object, e As EventArgs) Handles txtNouvVeh.TextChanged

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub cmdEnr_Click(sender As Object, e As EventArgs) Handles cmdEnr.Click

        Dim age As String ' âge de la voiture
        'stockage dans la bdd dans les objets
        '
        'Il faut stocker: 
        '
        '->le client
        ' maj le code identification, le nom et le prenom
        '2 possibilités 
        'soit une méthode qui reseigne des 3 attributs privés
        'soit 3 méthodes avec chaque fois una attribut

        unClientVoit.setCidtClient(cboCidt.Text)
        unClientVoit.setNomClient(txtNom.Text)
        unClientVoit.setPrenomClient(txtPrenom.Text)

        '
        uneVoiture.setEnregistreVehicule(txtNouvVeh.Text, txtAncVeh.Text)



        '->les données du véhicule
        'âge du véhicule

        '1er méthode
        'If rdbNeuf.Checked Then
        '    ' le bouton est coché
        '    age = rdbNeuf.Text
        'ElseIf rdbOcc3.Checked Then
        '    age = rdbOcc3.Text
        'ElseIf rdbOcc3a5.Checked Then
        '    age = rdbOcc3a5.Text
        'Else
        '    age = rdbOcc5.Text
        'End If

        'Pour afficher le message


        '2eme méthode
        Dim i As Integer
        Dim radio As RadioButton
        'For i = 0 To gpbAge.Controls.Count - 1
        '    radio = gpbAge.Controls(i) 'cas explicite pour bien dire que c'est un radoi boutton
        '    If radio.Checked Then 'recupere le controle
        '        age = radio.Text
        '    End If
        'Next
        'Incovénients : Parcourir toute la liste 

        '3eme méthode

        'For Each radio In gpbAge.Controls
        '    If radio.Checked Then 'recupere le controle
        '        age = radio.Text
        '    End If
        'Next


        '4eme méthodes

        i = 0
        radio = gpbAge.Controls(i)

        Do While radio.Checked = False And i < gpbAge.Controls.Count - 1
            i = i + 1 ' i+=1 sinon
            radio = gpbAge.Controls(i)
        Loop
        'je m'arrete au bon endroit, pas de besoin de parcourir toute la liste
        age = radio.Text

        MsgBox("ok")

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

    Private Sub cboCidt_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboCidt.SelectedIndexChanged

    End Sub

    Private Sub cboVendeur_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboVendeur.SelectedIndexChanged

    End Sub

    Private Sub cmdCredit_Click(sender As Object, e As EventArgs) Handles cmdCredit.Click

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

    Private Sub txtAncVeh_TextChanged(sender As Object, e As EventArgs) Handles txtAncVeh.TextChanged

    End Sub
End Class
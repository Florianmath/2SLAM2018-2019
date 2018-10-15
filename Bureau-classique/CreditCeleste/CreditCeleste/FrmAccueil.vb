﻿Public Class FrmAccueil
    Private Sub cmdIntroduction_Click(sender As Object, e As EventArgs) Handles cmdIntroduction.Click

        '' Dim fenIntro As New frmIntroduction  'porte  deja déclaré dans le module
        'Dim fenIntro2 As New frmIntroduction  '2 objets frm

        ''aller vers la fentre introduction

        'frmIntroduction.Show() 'affiche une classe

        If fenIntro Is Nothing Then
            fenIntro = New frmIntroduction  'desing pattern : singleton
        End If

        fenIntro.Show()  ' affichage de l'objet

        'fenIntro.ShowDialog() 'forcer la saisie / fentre modale
        fenIntro.BringToFront()   'pour le mettre en 1er plan 

        'fenIntro2.show()  ' affichage de l'objet

        Me.Hide() ' pour masquer la fentre active


    End Sub

    Private Sub FrmAccueil_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'uneConcession.setConcession() ' si déclaration avec new
        uneConcession = New Concession("Garage du parc", "4 rue des rossignole")

        'Creation un vendeur
        Dim unVendeur As New Vendeur("M.", "Velez", "Younes")
        Dim un2Vendeur As New Vendeur("M.", "Kreyder", "Armand")
        Dim un3Vendeur As New Vendeur("M.", "Sommer", "Malex")

        'rajouter mes 3 vendeurs

        uneConcession.lesVendeurs.Add(unVendeur)
        uneConcession.lesVendeurs.Add(un2Vendeur)
        uneConcession.lesVendeurs.Add(un3Vendeur)





    End Sub
End Class

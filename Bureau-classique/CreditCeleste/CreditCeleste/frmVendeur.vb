Public Class frmVendeur

    Private Sub frmVendeur_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        For Each Vendeur As Vendeur In uneConcession.lesVendeurs
            cboVendeur.Items.Add(Vendeur.getVendeur)


        Next
        cboVendeur.Text = unVendeur.getVendeur()

    End Sub

    Private Sub cmdIntroduction_Click(sender As Object, e As EventArgs) Handles cmdIntroduction.Click
        If fenIntro Is Nothing Then
            fenIntro = New frmIntroduction  'desing pattern : singleton
        End If

        fenIntro.Show()  ' affichage de l'objet

        'fenIntro.ShowDialog() 'forcer la saisie / fentre modale
        fenIntro.BringToFront()   'pour le mettre en 1er plan 

        'fenIntro2.show()  ' affichage de l'objet

        Me.Hide() ' pour masquer la fentre active
    End Sub

    Private Sub cboVendeur_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboVendeur.SelectedIndexChanged



        txtPalier.Text = unCredit.getMaVente
        txtTaux.Text = unCredit.getMonTaux
        txtMensualite.Text = unCredit.getMaMensualite
        'txtPartVendeur.Text = uneCommision
        'txtPartConcession.Text = uneCommision


        cboVendeur.Text = unVendeur.getVendeur()
    End Sub
End Class
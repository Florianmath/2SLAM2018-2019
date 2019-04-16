Public Class frmVendeur

    Private Sub frmVendeur_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        For Each Vendeur As Vendeur In uneConcession.lesVendeurs
            cboVendeur.Items.Add(Vendeur.getVendeur)


        Next
        '     cboVendeur.Text = unVendeur.getVendeur()
        'Pour fixer le premier enregitrement
        cboVendeur.Text = cboVendeur.Items(0)
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
        Dim i As Integer
        i = 1
        ListBox1.Items.Clear()


        'If unCredit.getNomVente = cboVendeur.Text Then


        'ListBox1.Items.Add(unCredit.getMaVente)

        'testak pour ajouter des donnees depuis la bdd kreyder athenas
        'ListBox1.Items.Contains(unVendeur.getVendeur)

        ListBox1.Items.Add("Vente numéro " + i.ToString)
        ListBox1.Items.Add(unCredit.getMaVente)
        i += 1




        ' Else
        'ListBox1.Items.Add("pas de vente")

        ' End If



        'ListBox1.Text = unCredit.getMaVente
        'txtTaux.Text = unCredit.getMonTaux
        'txtMensualite.Text = unCredit.getMaMensualite
        'txtPartVendeur.Text = uneCommision
        'txtPartConcession.Text = uneCommision



    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged

    End Sub
End Class
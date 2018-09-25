Public Class frmCredit
    Private Sub frmCredit_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' affichage du credit
        '
        'lire les credit des clients
        '


        txtCapital.Text = unCredit.getMonCapitale
        txtDuree.Text = unCredit.getMaDuree
        txtTaux.Text = unCredit.getMonTaux
        'txtMensualite.Text = unCredit.getMaMensualite ?????
        'todo ak





    End Sub

    Private Sub cmdValide_Click(sender As Object, e As EventArgs) Handles cmdValide.Click

        Dim unCredit As Credit = New Credit(Convert.ToDouble(txtTaux.Text), Convert.ToDouble(txtDuree.Text), Convert.ToDouble(txtCapital.Text))

        'Convert.ToDouble(txtMensualite.Text) = unCredit.mensualites()

        txtMensualite.Text = unCredit.mensualites()
        'Si la fentre est vide 
        If txtMensualite.Text <> 0 Then
            Convert.ToDouble(txtMensualite.Text)
        End If
        'Pour enregistrer
        unCredit.setEnregistreCredit(txtCapital.Text, txtTaux.Text, txtDuree.Text)

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
End Class
Public Class frmSaisieBien
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

    Private Sub frmSaisieBien_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' affichage des voitures
        '
        'lire les voitures des clients
        '




        txt1erDate.Text = uneVoiture.getMaDate1erImmat
        txtAnneeModele.Text = uneVoiture.getMonAnneeModele
        txtNumImmat.Text = uneVoiture.getMonNumImmat
        txtNumSerie.Text = uneVoiture.getMonNumSerie
        txtPuissance.Text = uneVoiture.getMaPuissance







        'de l'objet vers l'écran
    End Sub

    Private Sub cmdEnregistre_Click(sender As Object, e As EventArgs) Handles cmdEnregistre.Click


        'enregistre les données 
        uneVoiture.setbien(txt1erDate.Text, txtAnneeModele.Text, txtNumImmat.Text, txtNumSerie.Text, txtPuissance.Text)


        MsgBox("ok")

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
End Class
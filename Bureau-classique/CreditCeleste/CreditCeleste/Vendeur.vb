Public Class Vendeur

    'Partie privé
    Private monIdtVendeur As String
    Private monNomVendeur As String
    Private monPrenomVendeur As String

    'Constructeur
    '
    ' en C# et java le nom de la classe
    '
    Sub New()

    End Sub

    Sub New(ByVal idtVendeur As String, nomVendeur As String, PrenomVendeur As String)
        monIdtVendeur = idtVendeur
        monNomVendeur = nomVendeur
        monPrenomVendeur = PrenomVendeur
    End Sub


    Public Function getVendeur() As String

        Return monIdtVendeur + " " + monNomVendeur + " " + monPrenomVendeur

    End Function

End Class

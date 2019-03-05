Public Class Vendeur


    'SET : sert à affecter une valeur à une propriété

    'Get : sert à récupérer la valeur d'une propriété

    'Partie privé
    'Private monNumVendeur As String
    '
    Private monIdtVendeur As String
    Private monNomVendeur As String
    Private monPrenomVendeur As String

    ' 

    'Constructeur
    '
    ' en C# et java le nom de la classe
    '
    Sub New()

    End Sub

    Sub New(ByVal idtVendeur As String, nomVendeur As String, PrenomVendeur As String)
        ' monNumVendeur = numVendeur   ByVal numVendeur As String,
        monIdtVendeur = idtVendeur
        monNomVendeur = nomVendeur
        monPrenomVendeur = PrenomVendeur
    End Sub


    Sub setEnregistreVendeur(ByVal idtVendeur As String, ByVal nomVendeur As String, ByVal prenomVendeur As String)
        monIdtVendeur = idtVendeur
        monNomVendeur = nomVendeur
        monPrenomVendeur = prenomVendeur
    End Sub



    Public Function getVendeur() As String

        Return monIdtVendeur + " " + monNomVendeur + " " + monPrenomVendeur

    End Function

End Class

Public Class Concession

    'Partie privé
    Private monNomConcession As String
    'a decomposer
    Private monAdresseConcession As String
    'liste de vendeurs
    Public lesVendeurs As New List(Of Vendeur) ' collection fortement typée / New pour l'instancier
    ' à mettre en privé avec accesseurs (get/set)

    Sub New()

    End Sub

    Sub New(ByVal nomConcession As String, ByVal adresseConcession As String)
        monNomConcession = nomConcession
        monAdresseConcession = adresseConcession
    End Sub

    Sub setConcession(ByVal nomConcession As String, ByVal adresseConcession As String)
        monNomConcession = nomConcession
        monAdresseConcession = adresseConcession
    End Sub

End Class

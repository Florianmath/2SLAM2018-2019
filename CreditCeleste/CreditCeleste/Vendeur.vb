Public Class Vendeur


    'SET : sert à affecter une valeur à une propriété

    'Get : sert à récupérer la valeur d'une propriété

    'Partie privé
    'Private monNumVendeur As String
    '
    Private monIdtVendeur As String
    Private monNomVendeur As String
    Private monPrenomVendeur As String

    ' testak
    Private monTousVendeur As String
    Private monNumVendeur As Integer

    'Constructeur
    '
    ' en C# et java le nom de la classe
    '
    Sub New()

    End Sub
    'testak
    Sub New(nomVendeur As String, PrenomVendeur As String)
        monNomVendeur = nomVendeur
        monPrenomVendeur = PrenomVendeur
    End Sub

    'Sub New(ByVal idtVendeur As String, nomVendeur As String, PrenomVendeur As String)
    '    ' monNumVendeur = numVendeur   ByVal numVendeur As String,
    '    monIdtVendeur = idtVendeur
    '    monNomVendeur = nomVendeur
    '    monPrenomVendeur = PrenomVendeur
    'End Sub
    'modif
    Sub New(numVendeur As Integer, nomVendeur As String, PrenomVendeur As String)
        monNumVendeur = numVendeur
        monNomVendeur = nomVendeur
        monPrenomVendeur = PrenomVendeur
    End Sub

    'modif aks
    Sub setEnregistreVendeur(ByVal numVendeur As Integer, ByVal nomVendeur As String, ByVal prenomVendeur As String)
        monNumVendeur = numVendeur
        monNomVendeur = nomVendeur
        monPrenomVendeur = prenomVendeur
    End Sub

    'modif ak

    'Sub setEnregistreVendeur(ByVal idtVendeur As String, ByVal nomVendeur As String, ByVal prenomVendeur As String)
    '    monIdtVendeur = idtVendeur
    '    monNomVendeur = nomVendeur
    '    monPrenomVendeur = prenomVendeur
    'End Sub


    Sub setEnregistreVendeur(ByVal nomVendeur As String, ByVal prenomVendeur As String)
        monNomVendeur = nomVendeur
        monPrenomVendeur = prenomVendeur
    End Sub

    'test
    Sub setEnregistreTousVendeur(ByVal tousVendeur As String)
        monTousVendeur = tousVendeur

    End Sub

    Sub setEnregistreNumVendeur(ByVal numVendeur As String)
        monNumVendeur = numVendeur

    End Sub

    Public Function getEnregistreTousVendeur() As String
        Return monTousVendeur
    End Function

    Public Function getVendeur() As String

        'Return monIdtVendeur + " " + monNomVendeur + " " + monPrenomVendeur
        Return monNumVendeur.ToString + " " + monNomVendeur + " " + monPrenomVendeur
        ' Return monNomVendeur + " " + monPrenomVendeur

    End Function


    Public Function getNomVendeur() As String
        Return monNomVendeur
    End Function

    Public Function getPrenomVendeur() As String
        Return monPrenomVendeur
    End Function

    Public Function getNumVendeur() As Integer
        Return monNumVendeur
    End Function



End Class

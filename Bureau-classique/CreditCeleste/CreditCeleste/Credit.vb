Public Class Credit


    'SET : sert à affecter une valeur à une propriété

    'Get : sert à récupérer la valeur d'une propriété

    'Parties privés


    Private taux As Double = 0
    Private dure As Double = 0
    Private capitale As Double = 0
    '------------------------
    Private mensualite As Double = 0
    '------------------------
    Private palier As Integer = 0

    Private venteVendeur As String  'Lien avec la table Vendeur

    Sub New()

    End Sub

    Sub New(ByVal monTaux As Double, ByVal maDure As Double, ByVal monCapitale As Double)
        taux = monTaux
        dure = maDure
        capitale = monCapitale
    End Sub
    'Constructeur
    Public Sub New(ByVal t As Double, ByVal d As Integer, ByVal c As Integer)
        taux = t
        dure = d
        capitale = c
    End Sub

    'Méthode
    Public ReadOnly Property mensualites() As Double
        Get
            ' Math.Pow =  puissance (^)
            taux /= 100
            'Dim calcul As Double = capitale * ((taux / 100) / (1 - (Math.Pow(1 + taux, -dure))))
            Dim calcul As Double = Math.Round((capitale * (taux / 12)) / (1 - (Math.Pow(1 + (taux / 12), -dure))), 2)
            Return CType(calcul, Double)
        End Get
    End Property

    Sub setEnregistreCredit(ByVal monCapitale As Double, ByVal monTaux As Double, ByVal maDuree As Double, ByVal maMensualite As Double)
        capitale = monCapitale
        taux = monTaux
        dure = maDuree
        mensualite = maMensualite
    End Sub

    Sub setEnregistreVente(ByVal maVenteVendeur As String, ByVal monCapitale As Double, ByVal monTaux As Double, ByVal maDuree As Double, ByVal maMensualite As Double)
        venteVendeur = maVenteVendeur
        capitale = monCapitale
        dure = maDuree
        taux = monTaux
        mensualite = maMensualite
    End Sub

    Function getMaVente() As String

        Return (venteVendeur + " " + capitale.ToString + " " + taux.ToString + " " + dure.ToString + " " + mensualite.ToString)

    End Function

    Function getNomVente() As String

        Return (venteVendeur)

    End Function

    Function getMonCapitale() As Double

        Return (capitale)

    End Function

    Function getMonTaux() As Double

        Return (taux)

    End Function

    Function getMaDuree() As Double

        Return (dure)

    End Function

    Function getMaMensualite() As Double

        Return (mensualite)

    End Function
    '-------------------------------------

    Public Sub setCapitale(ByVal monCapitale As Double) ''''''
        capitale = monCapitale
    End Sub

    Public Sub setTaux(ByVal monTaux As Double) ''''''
        taux = monTaux
    End Sub

    Public Sub setDuree(ByVal maDuree As Double) ''''''
        dure = maDuree
    End Sub

    Public Sub setMensualite(ByVal maMensualite As Double) ''''''
        mensualite = maMensualite
    End Sub



End Class

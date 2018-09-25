Public Class Credit

    'Parties privés
    Private taux As Double = 0
    Private dure As Double = 0
    Private capitale As Double = 0
    '------------------------
    Private mensualite As Double = 0

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
            'Dim calcul As Double = capitale * ((taux / 100) / (1 - (Math.Pow(1 + taux, -dure))))
            Dim calcul As Double = (capitale * (taux / 100)) / (1 - (Math.Pow(1 + (taux / 100), -dure)))
            Return CType(calcul, Double)
        End Get
    End Property

    Sub setEnregistreCredit(ByVal monCapitale As Double, ByVal monTaux As Double, ByVal maDuree As Double)
        capitale = monCapitale
        taux = monTaux
        capitale = monCapitale
        'mensualite = maMensualite
    End Sub

    Function getMonCapitale() As Double

        Return (capitale)

    End Function

    Function getMonTaux() As Double

        Return (taux)

    End Function

    Function getMaDuree() As Double

        Return (dure)

    End Function


End Class

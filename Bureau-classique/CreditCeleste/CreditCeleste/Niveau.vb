Public Class Niveau

    'SET : sert à affecter une valeur à une propriété

    'Get : sert à récupérer la valeur d'une propriété

    'Parties privés
    Private leTaux As Double
    Private leLibelleTaux As String

    Sub New()

    End Sub

    Sub New(ByVal monTaux As Double, ByVal monLibelleTaux As Double)
        leTaux = monTaux
        leLibelleTaux = monLibelleTaux
    End Sub


    'Les paliers reste à définir
    'Exemples :
    'palier 1 = 0
    'palier 2 = 2
    '...

End Class

Public Class Commission

    'SET : sert à affecter une valeur à une propriété

    'Get : sert à récupérer la valeur d'une propriété

    'Parties privés
    Private lePalierVendeur As Double = 0
    Private leTauxVendeur As Double = 0 ' exemple de 4 a 0 (sans la part de l'entreprise)
    Private leMontantGagneVendeur As Double = 0
    Private laPartVendeur As Double = 0
    Private laPartConcession As Double = 0




    Sub New()

    End Sub

    Sub New(ByVal palierVendeur As Double, ByVal tauxVendeur As Double, ByVal montantVendeur As Double, ByVal partVendeur As Double, ByVal partConcession As Double)
        lePalierVendeur = palierVendeur
        leTauxVendeur = tauxVendeur
        leMontantGagneVendeur = montantVendeur
        laPartVendeur = partVendeur
        laPartConcession = partConcession
    End Sub

    'Reference de Credit et Vendeur pour faire un get?? 
    'Il faut faire une recheche du vendeur qui a le credit 1 pour le taux 1 par exemple


End Class

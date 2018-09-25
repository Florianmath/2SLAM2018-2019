Public Class Voiture

    'Partie privé
    'attribut

    Private monNomVehicule As String
    Private monAgeVehicule As String
    Private monAncienVehicule As String
    '-------------------------
    Private maDateDe1erImmat As String
    Private monAnneeModele As String
    Private monNumImmat As String
    Private monNumSerie As String
    Private maPuissanceVehicule As String

    'SET : sert à affecter une valeur à une propriété

    'Get : sert à récupérer la valeur d'une propriété

    Sub New()

    End Sub

    Sub New(ByVal nomVehicule As String, ByVal ageVehicule As String, ancienVehicule As String)
        monNomVehicule = nomVehicule
        monAgeVehicule = ageVehicule
        monAncienVehicule = ancienVehicule
    End Sub

    Sub setVoiture(ByVal nomVehicule As String, ByVal ageVehicule As String, ancienVehicule As String)
        monNomVehicule = nomVehicule
        monAgeVehicule = ageVehicule
        monAncienVehicule = ancienVehicule
    End Sub

    Sub setEnregistreVehicule(ByVal maVoiture As String, ByVal monAncienneVoiture As String)
        monNomVehicule = maVoiture
        monAncienVehicule = monAncienneVoiture
    End Sub

    '==================================
    Function getMaDate1erImmat() As String

        Return (maDateDe1erImmat)

    End Function
    Function getMonAnneeModele() As String

        Return (monAnneeModele)

    End Function

    Function getMonNumImmat() As String

        Return (monNumImmat)

    End Function

    Function getMonNumSerie() As String

        Return (monNumSerie)

    End Function
    Function getMaPuissance() As String

        Return (maPuissanceVehicule)

    End Function
    '=========================================

    Function getNomVehicule() As String

        Return (monNomVehicule)

    End Function
    Public Sub setNomVehicule(ByVal nomVehicule As String)
        monNomVehicule = nomVehicule
    End Sub


    Function getNomAncienVehicule() As String

        Return (monAncienVehicule)

    End Function
    Public Sub setNomAncienVehicuel(ByVal nomAncienVehicule As String) '''''''
        monAncienVehicule = nomAncienVehicule
    End Sub


    Public Sub setAge(ByVal age As String) ''''''
        monAgeVehicule = age
    End Sub

    Function getAge() As String
        getAge = monAgeVehicule
    End Function


    Sub setbien(ByVal d1éreImmat As String, ByVal anneeMod As String, ByVal numImma As String, ByVal numSerie As String, ByVal puiss As String)
        maDateDe1erImmat = d1éreImmat
        monAnneeModele = anneeMod
        monNumImmat = numImma
        monNumSerie = numSerie
        maPuissanceVehicule = puiss
    End Sub


End Class

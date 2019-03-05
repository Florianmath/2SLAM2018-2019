'Comme include
Imports csClient 'permet de récuperer le client en c#, lien physique


Public Class ClientVoit ' déclaration de la classe
    Inherits Client ' héritage, en c# : Client

End Class

Public Class ClientSpecifique ' déclaration de la classe
    Inherits ClientVoit ' héritage, en vb : ClientVoit

    'SET : sert à affecter une valeur à une propriété

    'Get : sert à récupérer la valeur d'une propriété

    'Parties privés
    Private dateDeNaissance As String
    Private revenuAnnuel As String
    Private profession As String
    Private nomDeJeuneFille As String


    'accesseurs
    '-------------------------------------
    'date de naissance
    '-------------------------------------
    Function getMaDateDeNaissance() As String

        Return (dateDeNaissance)

    End Function

    Public Sub setDateDeNaissance(ByVal maDateDeNaissance As String)
        dateDeNaissance = maDateDeNaissance
    End Sub

    '-------------------------------------
    'revenu ANNUEL
    '-------------------------------------
    Function getMonRevenuAnnuel() As String

        Return (revenuAnnuel)

    End Function

    Public Sub setRevenuAnnuel(ByVal monRevenuAnnuel As String)
        revenuAnnuel = monRevenuAnnuel
    End Sub

    'propriete
    '-------------------------------------
    'profession
    '-------------------------------------


    Public Property maProfession() As String
        Get
            Return (profession)
        End Get
        Set(ByVal value As String)
            profession = value
        End Set
    End Property

    'Function getMaProfession() As String

    '    Return (profession)

    'End Function

    'Public Sub setProfession(ByVal maProfession As String)
    '    profession = maProfession
    'End Sub

    '-------------------------------------
    'nom de jeune fille
    '-------------------------------------


    Public Property monNomDeJeunneFille() As String
        Get
            Return (nomDeJeuneFille)
        End Get
        Set(ByVal value As String)
            nomDeJeuneFille = value
        End Set
    End Property


    'Function getMonNomDeJeunneFille() As String

    '    Return (nomDeJeuneFille)

    'End Function

    'Public Sub setNomDeJeunneFille(ByVal monNomDeJeunneFille As String)
    '    nomDeJeuneFille = monNomDeJeunneFille
    'End Sub

End Class

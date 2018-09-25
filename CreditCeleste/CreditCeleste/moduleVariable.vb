Module moduleVariable


    '' accesible a tous le monde 
    Public fenIntro As frmIntroduction ' pas de new car le clique le crée


    Public uneConcession As New Concession() ' dans tous les cas une concession doit être crée

    Public uneVoiture As New Voiture ' dans tous les cas une voiture doit être crée

    'la voiture appartient au client 
    'il faut créer un client pour lui rattacher une voiture

    '------------------
    Public fenSaisie As frmSaisieBien
    Public fenCredit As frmCredit

    Public unClientVoit As New ClientVoit
    Public unCredit As New Credit

End Module

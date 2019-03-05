using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace csClient
{
    public class Client
    {
        //=======================================
        //Pour le type chaine de caractere privé  
        //=======================================
        private int numeroClient;
        private string cidtClient;     
        private string nomClient;
        private string prenomClient;
        private string adresseClient;

        //
        private string adresseMailClient;

        public Client()
        {

        }

        public Client(int numCli)
        {
            //entier
            numeroClient = numCli;
        }

        public Client(int numCli, string nomCli, string prenomCli)
        {
            //entier
            numeroClient = numCli;
            //texte
            nomClient = nomCli;
            prenomClient = prenomCli;
        }

        public Client(int numCli,string cidtCli, string nomCli, string prenomCli)
        {
            //entier
            numeroClient = numCli;
            //texte
            cidtClient = cidtCli;
            nomClient = nomCli;
            prenomClient = prenomCli;
        }


        public int getNumeroClient()
        {
            return numeroClient;
        }

        public void setNumeroClient(int numCli)
        {
            numeroClient = numCli;
        }

        //

        public string getCidtClient()
        {
            return cidtClient;
        }

        public void setCidtClient(string cidtCli)
        {
            cidtClient = cidtCli;
        }

        //

       

        public string getNomClient()
        {
            return nomClient;
        }

        public void setNomClient(string nomCli)
        {
            nomClient = nomCli;
        }

        //

        public string getPrenomClient()
        {
            return prenomClient;
        }

        public void setPrenomClient(string prenomCli)
        {
            prenomClient = prenomCli;
        }

        //

        public string getAdresseClient()
        {
            return adresseClient;
        }

        public void setAdresseClient(string adresseCli)
        {
            adresseClient = adresseCli;
        }

        //

        public string getAdresseMailClient()
        {
            return adresseMailClient;
        }

        public void setAdresseMailClient(string adresseMailCli)
        {
            adresseMailClient = adresseMailCli;
        }

    }
}


public class ClientGenerique : csClient.Client // heritage
{
   // private string adresse; DEJA REALISSE DANS LA CLASSE MERE
    private string codePostal;
    private string ville;
    private string telephone;


    //Accesseurs
    //--------------------------------------
    //Code Postale
    //--------------------------------------
    public string getmonCodePostal()
    {
        return codePostal;
    }

    public void setCodePostal(string monCodePostal)
    {
        codePostal = monCodePostal;
    }

    //Propriete
    //--------------------------------------
    //Ville
    //--------------------------------------


    public string Ville {    
        get
        {
            return ville;
        }

        set
        {
            ville = value;
        }
    }



    //--------------------------------------
    //Telephone
    //--------------------------------------

    public string Telephone
    {
        get
        {
            return telephone;
        }

        set 
        {
            telephone = value;
        }
    }
   



}
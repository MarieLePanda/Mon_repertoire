using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.IO;


namespace Repertoire 
{
    class Personne 
    {

        private String nom;
        private String prenom;
        private String nomPrenom;
        private Adresse adresse;
        private String telephone;
        private String telephonePro;
        private String email;
        private String emailPro;
        private String skype;
        private String note;
        private List<String> listeAttribut;

        private static int nbPersonne;

        //Constructeur 
        public Personne()
	    {
		    Console.WriteLine("Création de la personne");
		    nbPersonne++;
	    }

        public Personne(String unNom, String unPrenom, Adresse uneAdresse, String unTelephone,
                String unTelephonePro, String unEmail, String unEmailPro, String unSkype, String uneNote)
	    {
		    nom = unNom;	prenom = unPrenom;	adresse = uneAdresse;	telephone = unTelephone;
            telephonePro = unTelephonePro; email = unEmail; emailPro = unEmailPro; skype = unSkype; note = uneNote;
            nomPrenom = unNom + unPrenom;
		    nbPersonne++;
            Console.WriteLine("Création de la personne");
	    }

        public Personne(String[] uneListe)
	    {
		    nom = uneListe[0];
		    prenom = uneListe[1];
		    adresse = new Adresse(uneListe[2], uneListe[3], uneListe[4]);
            telephone = uneListe[5];
            telephonePro = uneListe[6];
            email = uneListe[7];
            emailPro = uneListe[8];
            skype = uneListe[9];
            note = uneListe[10];
            nomPrenom = uneListe[0] + uneListe[1];

		    nbPersonne++;
            Console.WriteLine("Création de la personne");
	    }



        //Fonction

        public void AfficheCoordonnees()
	    {
            Console.WriteLine("Nom : " + nom + "\nPrénom : " + prenom + "\nAdresse : " + adresse + "\nTéléphone : " + telephone + "\n------------------------------------------------\n");
	    }

        public String toString()
        {
            return (nom + ";" + prenom + ";" + adresse.getRue() + ";" + adresse.getVille() + ";" + adresse.getCodePostal() +
              ";" + telephone + ";" + telephonePro + ";" + email + ";" + emailPro + ";" + skype +";" + note);
        }

        // Get & Set
        public Adresse getAdresse()
        {
            return adresse;
        }

        public void setAdresse(Adresse adresse)
        {
            this.adresse = adresse;
        }

        public String getTelephone()
        {
            return telephone;
        }

        public void setTelephone(String telephone)
        {
            this.telephone = telephone;
        }

        public static int getNbPersonne()
        {
            return nbPersonne;
        }

        public static void setNbPersonne(int nbPersonne)
        {
            Personne.nbPersonne = nbPersonne;
        }

        public String getNom()
        {
            return nom;
        }

        public void setNom(String nom)
        {
            this.nom = nom;
        }

        public String getPrenom()
        {
            return prenom;
        }

        public void setPrenom(String prenom)
        {
            this.prenom = prenom;
        }

        public String getNomPrenom()
        {
            return nomPrenom;
        }

        public void setNomPrenom(String nomPrenom)
        {
            this.nomPrenom = nomPrenom;
        }

        public String getTelephonePro()
        {
            return telephonePro;
        }

        public void setTelephonePro(String telephonePro)
        {
            this.telephonePro = telephonePro;
        }

        public String getEmail()
        {
            return email;
        }

        public void setEmail(String email)
        {
            this.email = email;
        }

        public String getEmailPro()
        {
            return emailPro;
        }

        public void setEmailPro(String emailPro)
        {
            this.emailPro = emailPro;
        }

        public String getSkype()
        {
            return skype;
        }

        public void setSkype(String skype)
        {
            this.skype = skype;
        }

        public String getNote()
        {
            return note;
        }

        public void setNote(String note)
        {
            this.note = note;
        }

        public List<String> getListeAttribut()
        {
            return listeAttribut;
        }

        public void setListeAttribut(List<String> listeAttribut)
        {
            this.listeAttribut = listeAttribut;
        }
    }
}

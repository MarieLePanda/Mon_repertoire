using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.IO;
using Repertoire;



namespace Repertoire
{
    class Repertoire
    {
   
        private List<Personne> liste;

        //Constructeur
        public Repertoire()
        {
            liste = new List<Personne>();
            liste = Fichier.lecture();
            
           
                    

            
            Console.WriteLine("Création du repertoire");
        }

        //Fonction


        public int comparePersonne(Personne p1, Personne p2)
        {
            return String.Compare(p1.getNomPrenom(), p2.getNomPrenom());
        }

        public int tailleListe()
        {
            return liste.Count;
        }

        public void afficheRepertoire()
        {
            foreach (Personne pers in liste)
                Console.WriteLine(pers.toString());
        }

        public String renvoieRepertoire()
        {
            String description = "";
            foreach (Personne pers in liste)
            {
                description += pers.toString();
            }
            return description;
        }

        public Personne recherchePersonne(int unIndice)
        {
            Personne resultat = null;
            resultat = liste[unIndice];

            return resultat;
        }

        public void ajouterPersonne(String unNom, String unPrenom, Adresse uneAdresse, String unTelephone,
                String unTelephonePro, String unEmail, String unEmailPro, String unSkype, String uneNote)
        {
            Personne p = new Personne(unNom, unPrenom, uneAdresse, unTelephone, 
                        unTelephonePro, unEmail, unEmailPro, unSkype, uneNote);
            p.AfficheCoordonnees();
            liste.Add(p);
            liste.Sort(comparePersonne);
        }

        public void sauvegarder()
        {
            liste.Sort(comparePersonne);
            Fichier.ecriture(liste);
            Console.WriteLine(liste.ToString());
        }

        public void supprPersonne(Personne unePersonne)
        {
            liste.Remove(unePersonne);
        }

        public Personne recherche(String unNom, String unPrenom)
        {
            Personne resultat = null;
            foreach (Personne pers in liste)
            {
                if (unNom == pers.getNom() && unPrenom == pers.getPrenom())
                {
                    resultat = pers;
                }
            }
            return resultat;
        }

        public List<Personne> getListe()
        {
            return liste;
        }
    }


}



	

 

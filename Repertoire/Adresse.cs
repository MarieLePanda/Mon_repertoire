using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace Repertoire
{
    public class Adresse
    {


        private String rue;
        private String codePostal;
        private String ville;


        //Constructeur
        public Adresse(String uneRue, String unCodePostal, String uneVille)
        {
            rue = uneRue; codePostal = unCodePostal; ville = uneVille;
            Console.WriteLine("Création de l'adresse");
        }

        // Fonction
        public void afficheAdresse()
        {
            Console.WriteLine(rue + "\n\t" + codePostal + "\n\t" + ville);
        }

        public String renvoieAdresse()
        {
            return (rue + "\n\t" + codePostal + "\n\t" + ville);
        }

        public String toString()
        {
            return (rue + ";" + codePostal + ";" + ville);
        }

        // Getteur & Setteur
        public String getRue()
        {
            return rue;
        }

        public void setRue(String rue)
        {
            this.rue = rue;
        }

        public String getCodePostal()
        {
            return codePostal;
        }

        public void setCodePostal(String codePostal)
        {
            this.codePostal = codePostal;
        }

        public String getVille()
        {
            return ville;
        }

        public void setVille(String ville)
        {
            this.ville = ville;
        }
    }
}

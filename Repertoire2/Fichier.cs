using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Repertoire
{
    class Fichier
    {
        public static List<Personne> lecture()
        {
            StreamReader fichierLecture = null;
            List<Personne> listePersonne = new List<Personne>();
            try
            {
                fichierLecture = new StreamReader("repertoire.txt");
                String ligne;

                while ((ligne = fichierLecture.ReadLine()) != null)
                {

                    listePersonne.Add(new Personne(ligne.Split(';')));

                }
                fichierLecture.Close();
            }

            catch (FileNotFoundException err)
            {
                Console.WriteLine(err.ToString());
            }

            catch (IOException err)
            {
                Console.WriteLine(err.ToString());
            }

            return listePersonne;
        }


        public static void ecriture(List<Personne> liste)
        {
		try{
			
			StreamWriter ficherEcriture = new StreamWriter("repertoire.txt");

			foreach (Personne pers in liste)
			{
                ficherEcriture.WriteLine(pers.toString());
			}
            ficherEcriture.Close();
		}
		catch(IOException err){
            Console.WriteLine(err.ToString());
		}
	}

    }
}

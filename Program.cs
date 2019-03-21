using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternFacade
{
    class Program
    {
        static void Main(string[] args)
        {
            
            CAF CAF = new CAF();
            int choixBoucleInt = 0;
            do
            {
                try
                {
                    Console.WriteLine("\r\nQue voulez-vous faire ?\r\n1) Ajouter un Dossier\r\n2) Afficher la liste des dossiers\r\n3) Traiter un dossier\r\n4) Quitter");
                choixBoucleInt = Int32.Parse(Console.ReadLine());
                
                    switch (choixBoucleInt)
                    {
                        case 1:
                            Console.WriteLine("Quel est le nom?");
                            string nom = Console.ReadLine();
                            Console.WriteLine("De combien est le salaire mensuel?");
                            int salaire = Int32.Parse(Console.ReadLine());
                            Console.WriteLine("De combien est le loyer?");
                            int loyer = Int32.Parse(Console.ReadLine());
                            Console.WriteLine("Combien d'enfant à charge?");
                            int nbenfant = Int32.Parse(Console.ReadLine());
                            CAF.BureauArchive.ListeDossier.Add(new Dossier(nom, salaire, loyer, nbenfant));
                            Console.WriteLine("\r\n");
                            break;
                        case 2:
                            if (CAF.BureauArchive.ListeDossier.Count == 0)
                            {
                                Console.WriteLine("La liste est vide");
                            }
                            else
                            {
                                Console.WriteLine("La liste est composé de : \r\n");
                                CAF.BureauArchive.AfficherListeDesDossiers();
                                Console.WriteLine("\r\n");
                            }
                            break;
                        case 3:
                            if (CAF.BureauArchive.ListeDossier.Count == 0)
                            {
                                Console.WriteLine("La liste est vide");
                            }
                            else
                            {
                                Console.WriteLine("De qui faire le traitement ? Avec le chiffre");
                                CAF.BureauArchive.AfficherListeDesDossiers();
                                choixBoucleInt = Int32.Parse(Console.ReadLine());
                                CAF.Traitement(CAF.BureauArchive.ListeDossier[choixBoucleInt - 1]);
                                Console.WriteLine("\r\n");
                            }
                            break;
                    }
                } 
                catch
                {
                    Console.WriteLine("mauvaise saisie, retour au menu");
                }

            } while (choixBoucleInt != 4);


            
        }
    }
}

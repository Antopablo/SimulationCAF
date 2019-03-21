using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternFacade
{
    internal class BureauArchive
    {
        public BureauArchive(List<Dossier> listeDossier)
        {
            ListeDossier = listeDossier;
        }

        private List<Dossier> _ListeDossier;
        public List<Dossier> ListeDossier
        {
            get { return _ListeDossier; }
            set { _ListeDossier = value; }
        }

        public void AfficherListeDesDossiers ()
        {
            int i = 0;
            foreach (Dossier item in ListeDossier)
            {
               
                Console.WriteLine((i+1) +" " + item.Nom);
                i++;
            }
        }

    }
}
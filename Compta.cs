using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DesignPatternFacade
{
    internal class Compta
    {
        public void PayerAlloc(Dossier dos)
        {
            if (dos.EligibleFam ==true || dos.EligibleLog == true)
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("La CAF paye "+dos.Alloc+ " euros");
                Console.ForegroundColor = ConsoleColor.White;
            } else
            {
                dos.Dette = 0;
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Vous n'êtes éligible à aucune aide");
                Console.ForegroundColor = ConsoleColor.White;
            }
        }

       
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DesignPatternFacade
{
    internal class BureauAllocationLog
    {
        public void TestAllocLog(Dossier dos)
        {
            if (dos.Salaire < (dos.Loyer) * 2)
            {
                dos.EligibleLog = true;
                dos.Alloc += (dos.Loyer * 30 / 100);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(dos.Nom + " éligible à l'alloc logement");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(dos.Nom+" pas éligibile à l'alloc logement");
                Console.ForegroundColor = ConsoleColor.White;
            }
        }
    }
   
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DesignPatternFacade
{
    internal class BureauAllocationFam
    {
        public void TestAllocFam(Dossier dos)
        {
            if (dos.NbEnfant > 0)
            {
                dos.EligibleFam = true;
                dos.Alloc += 85*dos.NbEnfant;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(dos.Nom+" éligible à l'alloc Familiale");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(dos.Nom+" pas éligibile à l'alloc Familiale");
                Console.ForegroundColor = ConsoleColor.White;
            }
        }
    }
}
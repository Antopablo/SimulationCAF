using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternFacade
{
    class BureauRecouvrement
    {
        

        public void VerifierDette(Dossier dos)
        {
            if (dos.EligibleFam == true || dos.EligibleLog == true)
            {
                if (dos.Dette > 0)
                {
                    Console.WriteLine("Alloc avant dette : " + dos.Alloc);
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Dette : " + dos.Dette + " euros");
                    Console.ForegroundColor = ConsoleColor.White;
                    dos.Alloc -= dos.Dette;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("pas de dette");
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }
        }

        public int GenererDette(Dossier dos)
        {
            int Dette = RandomMaison.Instance.Next(0, 5);
            if (Dette < 3)
            {
                Dette = RandomMaison.Instance.Next(0, 100);
                dos.Dette += Dette;
                
            } else
            {
                Dette = 0;
            }

            return Dette;
        }


    }
}

using FirstTry;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mine_moodel_Prosjekter
{
    internal class prog10
    {
        public void TekstTukling() 
        {
            Console.WriteLine("Hmmm...");

            
            
            Console.Write("Prøve en gang til? (J/N): ");
            var answer1 = Console.ReadLine();
            answer1 = answer1.ToUpper();

            if (answer1 == "J")
            {
                TekstTukling();
            }
            else
            {
                Program.Main();
            }
        }
    }
}

using FirstTry;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mine_moodel_Prosjekter
{
    internal class prog9
    {
        public int talletDuSkalGjette;
        public void GjettTallet() 
        {
            

            Random random = new Random();
            talletDuSkalGjette = random.Next(1, 11);
            GjetteSpill();
        }

        public void GjetteSpill() 
        {
            int userInput;
            Console.WriteLine("Gjett Tallet mellom 1-10: ");
            userInput = Convert.ToInt32(Console.ReadLine());

            if (userInput == talletDuSkalGjette) 
            { Console.WriteLine("du gjettet riktig!!!");}
            
            else if (userInput > talletDuSkalGjette) 
            { Console.WriteLine("Du gjettet for høyt!"); GjetteSpill(); }
            else if (userInput < talletDuSkalGjette) 
            { Console.WriteLine("Du gjettet for lavt"); GjetteSpill(); }
            else { Console.WriteLine("why, just WHY!!"); }

            Console.Write("Prøve en gang til? (J/N): ");
            var answer1 = Console.ReadLine();
            answer1 = answer1.ToUpper();

            if (answer1 == "J")
            {
                GjettTallet();
            }
            else
            {
                Program.Main();
            }

        }
    }
}

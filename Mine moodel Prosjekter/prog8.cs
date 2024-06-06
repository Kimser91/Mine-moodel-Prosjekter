using FirstTry;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mine_moodel_Prosjekter
{
    internal class prog8
    {
        public int tall1;
        public int tall2;
        public string answer = "_";
        public string result;
        
        public void Krokodillespillet() 
        {
           
            Random rand = new Random();
            tall1 = rand.Next(1, 12);
            Random rand1 = new Random();
            tall2 = rand1.Next(1, 12);

            Console.WriteLine("velkommen til krokodillespillet mitt :-)");
            Console.WriteLine("er tallet større enn, mindre enn eller lik det andre tallet?");
            Console.WriteLine("gi dtitt svar ved å bruke tegnene: < , > , =");
            Console.WriteLine($"{tall1} og {tall2}");
            answer = Console.ReadLine();
            

            if ( tall1 == tall2 && answer == "=" ) { result = "riktig"; }
            else if ( tall1 < tall2 && answer == "<") { result = "riktig"; }
            else if ( tall1 > tall2 && answer == ">") { result = "riktig"; }
            else { result = "feil"; }
            
            Console.WriteLine($"Svaret ditt er {result}");

            Console.Write("ny runde? (J/N): ");
            var answer1 = Console.ReadLine();
            answer1 = answer1.ToUpper();

            if (answer1 == "J")
            {
                
                Krokodillespillet();
            }
            else
            {
                Program.Main();
            }

        }
    }
}

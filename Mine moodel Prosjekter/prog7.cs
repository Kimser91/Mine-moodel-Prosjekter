using FirstTry;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mine_moodel_Prosjekter
{
    internal class prog7
    {
        public void ForeLoops() 
        { 
            for (int i = 0; i < 5; i++) 
            { Console.WriteLine("Terje er Kul, men Marie er Best"); }
            var While = true;
            var nr = 0;
            string[] bokstaver = {"A", "B", "C", "D", "E" };
            while (While == true) { Console.WriteLine($"runde: {nr + 1}"); if (nr == 9) { While = false; } nr = nr + 1; }

            foreach (var bokstav in bokstaver) { Console.WriteLine(bokstav); }

            Console.Write("se en gang til? (J/N): ");
            var answer1 = Console.ReadLine();
            answer1 = answer1.ToUpper();

            if (answer1 == "J")
            {
                ForeLoops();
            }
            else
            {
                Program.Main();
            }
        }
    }
}

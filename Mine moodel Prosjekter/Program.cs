using System;
using System.Security.Cryptography.X509Certificates;

namespace FirstTry
{
    internal class Program
    {
        public static bool onload = true;
        public static int list = 0;

        public static void Main()
        {
            onload = false;
            list = 0;
            Console.Clear();
            Console.WriteLine("Velkommen! klar for noen artige tester?");
            Console.WriteLine("1. Stein saks papir, kan du slå meg?");
            Console.WriteLine("2. Kalkulator");
            Console.WriteLine("3. Tilfeldig tall med if/else");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            

            int MenuChoise = int.Parse(Console.ReadLine());
            CheckInput(MenuChoise);

        }

        static void CheckInput(int userChoice) { 
        switch (userChoice)
            {
                case 1:
                    Prog1.StoneScissorsPaper();
                    break;

                case 2:
                    Prog2.BasicCalculator();
                    break;

                case 3:
                    Prog3.RandomNumber();
                    break;
            }
        }
    }
}

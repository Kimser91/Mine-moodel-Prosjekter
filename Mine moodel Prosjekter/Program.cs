using Mine_moodel_Prosjekter;
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
            Console.WriteLine("4. variabler og bruk");
            Console.WriteLine("5. Grunnleggende C#");
            Console.WriteLine("6. Random Hobby");
            Console.WriteLine("7. For løkker");
            Console.WriteLine("8. Krokodillespillet");
            

            int userChoice = int.Parse(Console.ReadLine());
            CheckInput(userChoice);

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
                case 4:

                    Prog4.Variabeltyper();
                    break;
                case 5:
                    var prog5 = new Prog5();
                    prog5.grunnleggendeCsharp();
                    break;
                case 6:
                    var prog6 = new prog6();
                    prog6.hobbyAsigner();
                    break;
                case 7:
                    var prog7 = new prog7();
                    prog7.ForeLoops();
                    break;
                case 8:
                    var prog8 = new prog8();
                    prog8.Krokodillespillet();
                    break;

                

            }

        }
    }
}

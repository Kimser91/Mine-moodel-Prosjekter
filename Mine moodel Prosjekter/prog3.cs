using System;


namespace FirstTry
{
    internal class Prog3
    {
        public static void RandomNumber()
        {
            Console.Clear();
            Random rand = new Random();
            var rnd = rand.Next(0, 3);
            if (rnd == 0)
            {
                Console.WriteLine("tallet ble 0");
            }

            else if (rnd == 1) 
            {
                Console.WriteLine("tallet ble 1");
            }

            else
            { 
                Console.WriteLine("tallet ble 2");
            }

            Console.Write("nytt random tall? (J/N): ");
            var answer1 = Console.ReadLine();
            answer1 = answer1.ToUpper();

            if (answer1 == "J")
            {
                RandomNumber();
            }
            else
            {
                Program.Main();
            }
        }

    }
}

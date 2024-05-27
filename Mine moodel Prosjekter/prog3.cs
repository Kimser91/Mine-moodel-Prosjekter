using System;


namespace FirstTry
{
    internal class Prog3
    {
        public static void RandomNumber()
        {
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
        }

    }
}

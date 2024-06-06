using System;
using System.Security.Cryptography.X509Certificates;

namespace FirstTry
{
    internal class Prog4
    {
       
       


        public static void Variabeltyper()
        {
            int a = 1;
            long b = 9223372036754775807;
            float c = 2342423.4234f;
            decimal d = 3.141592653m;
            double e = 2.555;
            string f = "hello 5 high fives";
            char g = 'A';
            bool h = false;
            decimal sum = a + d;

            Console.Clear();
            Console.WriteLine("int:" + a);
            Console.WriteLine("long:" +  b);
            Console.WriteLine("float:" + c);
            Console.WriteLine("decimal:" +  d);
            Console.WriteLine("double:" +  e);
            Console.WriteLine("string:" +  f);
            Console.WriteLine("char:" +  g);
            Console.WriteLine("bool:" + h);
            Console.WriteLine("sum = " + sum );

            ReturnValues();
            returnerTilMain();
        }   
        
        public static void returnerTilMain()
        {
            Console.Write("tilbake til forsiden? (J/N): ");
            var answer1 = Console.ReadLine();
            answer1 = answer1.ToUpper();

            if (answer1 == "N")
            {
                Variabeltyper();
            }
            else
            {
                Program.Main();
            }
        }

        public static string ReturnString()
        { return "hei på deg"; }

        public static int ReturnInt()
        { return 55; }

        public static decimal ReturnDecimal()
        { return 32.234m; }

        public static double ReturnDouble()
        { return 23.2345; }

        public static bool ReturnBool()
        { bool bool1 = true; return bool1; }

        public static string ReturnNothing()
        {
            Console.WriteLine("Denne metoden returnerer ingenting");
            return "";
        }

        public static int returnTwoNumebers(int number1, int number2)
        {
            return number1 + number2;  
        }

        public static void ReturnValues() 
        {
            int num1 = 2;
            int num2 = 3;
            Console.WriteLine($"string: {ReturnString()}");
            Console.WriteLine($"Int: {ReturnInt()}");
            Console.WriteLine($"Decimal: {ReturnDecimal()}");
            Console.WriteLine($"Double: {ReturnDouble()}");
            Console.WriteLine($"Bool: {ReturnBool()}");
            Console.WriteLine($"legg sammen tall: {returnTwoNumebers(num1, num2)}");
            Console.WriteLine($"ingenting: {ReturnNothing()}");
        }
    }
}
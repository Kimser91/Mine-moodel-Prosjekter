using System;


namespace FirstTry
{
    internal class Prog2
    {
        public static void BasicCalculator()
        {
            int firstNumber = 0;
            int secondNumber = 0;
            int answer;
            string operations;
            
            Console.Clear();
            Console.WriteLine("Takk for at du tester min kalkulator");

            Console.WriteLine("Skriv inn første NR:");
              firstNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("skriv inn andre NR:");
              secondNumber = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("hva ønsker du å gjøre? *,/,+,-,?");
              operations = Console.ReadLine();

            
            if (operations == "*") 
            {   answer = firstNumber * secondNumber;
                Console.WriteLine(firstNumber + "*" + secondNumber + "=" + answer); 
                    
            }

            else if (operations == "/") { 
                answer = firstNumber / secondNumber;
                Console.WriteLine(firstNumber + "/" + secondNumber + "=" + answer);
            }

            else if (operations == "+")
            {
                answer = firstNumber + secondNumber;
                Console.WriteLine(firstNumber + "+" + secondNumber + "=" + answer);
            }

            else if (operations == "-")
            {
                answer = firstNumber - secondNumber;
                Console.WriteLine(firstNumber + "-" + secondNumber + "=" + answer);
            }

            else { Console.WriteLine("Beklager ikke korrekt format på regnestykket, prøv igjen"); }

            Console.Write("nytt regnestykke? (J/N): ");
            var answer1 = Console.ReadLine();
            answer1 = answer1.ToUpper();

            if (answer1 == "J")
            {
                BasicCalculator();
            }
            else
            {
                Program.Main();
            }
        }
    }
}
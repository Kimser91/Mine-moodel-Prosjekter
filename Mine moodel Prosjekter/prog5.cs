using System;

namespace FirstTry
{
    internal class Prog5
    {
        public int firstNumber = 0;
        public int secondNumber = 0;
        public int thirdNumber;
        public void grunnleggendeCsharp()
        {


            Console.Clear();
            Console.Write("skriv inn første nr:");
            firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.Write("skriv inn andre nr:");
            secondNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("viss tallene dine er like blirdi multiplisert om de er ulike blir de addert");
            Console.WriteLine($"Summen av dine tall er: {MathOnNumbers()}");
            Console.WriteLine($"det ble 30? {CheckIf30()}");
            Console.WriteLine($"Tallene dine er like: {CheckNumbers()}");
            Console.Write("start på nytt? (J/N): ");
            var answer = Console.ReadLine();
            answer = answer.ToUpper();

            if (answer == "J")
            {
                grunnleggendeCsharp();
            }
            else
            {
                Program.Main();
            }
        }

        public bool CheckNumbers() 
        { if (firstNumber == secondNumber)
            { return true; }
          
          else {  return false; }
        }

        public double MathOnNumbers()
        {
            if (firstNumber == secondNumber)
            {
                var answer = firstNumber * secondNumber;
                thirdNumber = answer;
                return answer;
            }

            else
            {
                var answer = firstNumber + secondNumber;
                thirdNumber = answer;
                return answer;
            }
        }

        public bool CheckIf30() {  if (thirdNumber == 30) 
            {  
                return true; 
            } 
            else 
            { 
                return false; 
            } 
        }


    }
}
using FirstTry;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mine_moodel_Prosjekter
{
    internal class prog6
    {
        public string chosenPerson;
        public int rnd;

        

        public void hobbyAsigner()
        {
            ChosenPerson();
            RandomHobbyGenerator();
        }
        public void RandomHobbyGenerator() 
        {
            Console.WriteLine($"{chosenPerson} sin hobby er {RandomHobby()}");

            Console.Write("ny hobby? (J/N): ");
            var answer1 = Console.ReadLine();
            answer1 = answer1.ToUpper();

            if (answer1 == "J")
            {
                RandomHobbyGenerator();
            }
            else
            {
                Program.Main();
            }
        }

        public string RandomHobby() 
        {   
            Random rand = new Random();
             rnd = rand.Next(0,5);
            if (rnd == 0) 
            {
                return "Mekaniker";
            }
            else if (rnd == 1) 
            {
                return "Magiker";       }
            else if (rnd == 2) 
            {
                return "IT Utvikler";
            }
            else 
            {
                return "Kjede seg";
            }
        }

        public string ChosenPerson() 
        {
            Console.WriteLine("hvem ønsker du å gi en hobby til?");
            Console.WriteLine("1. Terje");
            Console.WriteLine("2. Marie");
            Console.WriteLine("3. Eskil");
            Console.WriteLine("4. Rebecka");
            Console.WriteLine("5. Martin");
            Console.WriteLine("ønsker du å skrive selv? skriv en random bokstav");
            var userInput =  Console.ReadLine();
            if (userInput == "1") { chosenPerson = "Terje";}
            else if (userInput == "2") { chosenPerson = "Marie"; }
            else if (userInput == "3") { chosenPerson = "Eskil"; }
            else if (userInput == "4") { chosenPerson = "Rebecka"; }
            else if (userInput == "5") { chosenPerson = "Martin"; }
            else { chosenPerson = Console.ReadLine(); }

            return chosenPerson;
        }
    }
}

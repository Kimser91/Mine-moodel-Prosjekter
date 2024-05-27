using System;

namespace FirstTry
{
    internal class Prog1
    {
        public static void StoneScissorsPaper()
        {
        
                Random random = new Random();
                bool playAgain = true;
                String player;
                String computer;
                String answer;

            while (playAgain)
            {
                player = "";
                computer = "";
                answer = "";

                while (player != "STEIN" && player != "PAPIR" && player != "SAKS")
                {
                    Console.Write("Skriv: Stein, Saks eller Papir ");
                    player = Console.ReadLine();
                    player = player.ToUpper();
                }


                switch (random.Next(1, 4))
                {
                    case 1:
                        computer = "STEIN";
                        break;
                    case 2:
                        computer = "PAPIR";
                        break;
                    case 3:
                        computer = "SAKS";
                        break;
                }

                Console.WriteLine("Spiller: " + player);
                Console.WriteLine("AI: " + computer);

                switch (player)
                {
                    case "STEIN":
                        if (computer == "STEIN")
                        {
                            Console.WriteLine("Uavgjort!");
                        }
                        else if (computer == "PAPIR")
                        {
                            Console.WriteLine("Du Tapte!");
                        }
                        else
                        {
                            Console.WriteLine("Du Vant!");
                        }
                        break;
                    case "PAPIR":
                        if (computer == "STEIN")
                        {
                            Console.WriteLine("Du Vant!");
                        }
                        else if (computer == "PAPIR")
                        {
                            Console.WriteLine("Uavgjort!");
                        }
                        else
                        {
                            Console.WriteLine("Du Tapte!");
                        }
                        break;
                    case "SAKS":
                        if (computer == "STEIN")
                        {
                            Console.WriteLine("Du Tapte!");
                        }
                        else if (computer == "PAPIR")
                        {
                            Console.WriteLine("Du Vant!");
                        }
                        else
                        {
                            Console.WriteLine("Uavgjort!");
                        }
                        break;
                }

                Console.Write("Omkamp? (J/N): ");
                answer = Console.ReadLine();
                answer = answer.ToUpper();

                if (answer == "J")
                {
                    playAgain = true;
                }
                else
                {
                    Program.Main();
                }


            }
        }
    }
}
    


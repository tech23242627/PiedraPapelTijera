using System.Threading.Channels;

namespace PiedraPapelTijera
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int playerScore = 0;
            int enemyScore = 0;
            Random random = new Random();

            Console.WriteLine("");
            Console.WriteLine("Welcome to Rock Paper Scissors Game");
            Console.WriteLine("");

            while (playerScore != 3 && enemyScore != 3)
            {
                Console.WriteLine("");
                Console.WriteLine("Please enter 'r' for ROCK, 'P' FOR PAPER  or anything else for SCISSORS");
                Console.WriteLine("");
                string playerSelection = Console.ReadLine();

                int enemySelection = random.Next(0, 3);

                if (enemySelection == 0)
                {
                    switch (playerSelection)
                    {
                        case "r":
                            Console.WriteLine("TIE (Enemy choose ROCK)");
                            break;
                        case "p":
                            Console.WriteLine("YOU WIN (Enemy choose ROCK)");
                            playerScore++;
                            break;
                        default:
                            Console.WriteLine("YOU LOSE (Enemy choose ROCK)");
                            enemyScore++;
                            break;
                    }
                }

                else if (enemySelection == 1)
                {
                    switch (playerSelection)
                    {
                        case "p":
                            Console.WriteLine("TIE (Enemy choose PAPER)");
                            break;
                        case "r":
                            Console.WriteLine("YOU LOSE (Enemy choose PAPER)");
                            enemyScore++;
                            break;
                        default:
                            Console.WriteLine("YOU win (Enemy choose PAPER )");
                            playerScore++;
                            break;
                    }

                }

                else
                {
                    switch (playerSelection)
                    {
                        case "r":
                            Console.WriteLine("YOU WIN (Enemy choose SCISSORS)");
                            playerScore++;
                            break;
                        case "p":
                            Console.WriteLine("YOU LOSE (Enemy choose SCISSORS)");
                            enemyScore++;
                            break;
                        default:
                            Console.WriteLine("TIE (Enemy choose SCISSORS )");                            
                            break;
                    }
                }

                Console.WriteLine("");
            }

            
            Console.WriteLine("WINS: " + playerScore);
            Console.WriteLine("LOSE: " + enemyScore);
            
        }

        
    }
}

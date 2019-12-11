using System;

namespace DrNimGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("   ---   Doctor Nim Game   ---   ");

            InitializeGame();

            Game();
        }

        static void Game()
        {
            int tokens = ChooseDifficulty();

            int tokensToSubtract = 0;
            int tokensComputerTakes = 0;

            for (int i = 0; i <= tokens;)
            {

                // user turn
                Console.WriteLine($"Tokens Left = {tokens}, choose how many to take;");

                // The user chooses how many tokens to take. He can choose between 1, 2 or 3.
                userchoiceoftokens:
                tokensToSubtract = Convert.ToInt32(Console.ReadLine());
                if (tokensToSubtract != 1 && tokensToSubtract != 2 && tokensToSubtract != 3)
                {
                    Console.WriteLine("You have to choose between 1, 2 or 3 tokens");
                    goto userchoiceoftokens;
                }

                // subtracts the chosen number from the tokens left
                tokens -= tokensToSubtract;

                // computer turn
                tokensComputerTakes = 4 - tokensToSubtract;
                Console.WriteLine($"\nThere was {tokens} tokens left after your turn, the computer takes {tokensComputerTakes} tokens");
                tokens -= tokensComputerTakes;

                if (tokens == 0) { break; }
            }

            Console.WriteLine(" \n Computer Wins!");
        }

        static int ChooseDifficulty()
        {
            Console.WriteLine("Choose your difficulty, type in number 1, 2 or 3, with 1 being the easiest and 3 being the hardest");

            ChooseDifficulty:
            int userChosendifficulty = Convert.ToInt32(Console.ReadLine());
            if (userChosendifficulty != 1 && userChosendifficulty != 2 && userChosendifficulty != 3)
            {
                Console.WriteLine("Invalid Difficulty");
                goto ChooseDifficulty;
            }


            int tokens = 0;

            switch (userChosendifficulty)
            {
                case 1:
                    tokens = 12;
                    break;

                case 2:
                    tokens = 24;
                    break;

                case 3:
                    tokens = 36;
                    break;

                default:
                    Console.WriteLine("Something Went Wrong :(");
                    break;
            }

            return tokens;
        }

        static void InitializeGame()
        {
            Console.WriteLine("Type RULES for rules, press enter to start");
            string userInput = Console.ReadLine();

            if (userInput == "RULES")
            {
                Console.WriteLine("This feature has not been added yet");
            }
        }
    }
}

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
                try
                {
                    tokensToSubtract = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Not a valid number");
                    goto userchoiceoftokens;
                }

                
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
            string userChosendifficulty = Console.ReadLine();
            int difficulty = 0;

            try
            {
                difficulty = Convert.ToInt32(userChosendifficulty);
            }
            catch
            {
                Console.WriteLine("You wrote an invalid difficulty please try again");
                goto ChooseDifficulty;
            }


            if (difficulty != 1 && difficulty != 2 && difficulty != 3)
            {
                Console.WriteLine("Invalid Difficulty");
                goto ChooseDifficulty;
            }


            int tokens = 0;

            switch (difficulty)
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

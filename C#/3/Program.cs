namespace _3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //rock paper scissor
            //0 is rock, 1 is paper, 2 is scissors
            //random num generator
            //asks for what you chose and checks it against computer
            //says the results and how many games each one

            Random rand = new Random();
            int compGuess = rand.Next(0, 3);
            string compChoice = "";

            if(compGuess == 0)
            {
                compChoice = "r";
                //Console.WriteLine("The computer guessed rock.");
            } else if (compGuess == 1)
            {
                compChoice = "p";
                //Console.WriteLine("The computer guessed paper.");
            }
            else if (compGuess == 2)
            {
                compChoice = "s";
                //Console.WriteLine("The computer guessed scissors.");
            }


            int win = 0;
            int loss = 0;
            int tie = 0;
            //int attempts = 0;
            bool playing = true;

            while (playing)
            {
                //Console.WriteLine(compChoice);

                Console.WriteLine("Welcome to Rock, Paper, Scissors!");
                Console.WriteLine("Choose r for Rock, p for Paper, and s for Scissors.");

                String userGuess = Console.ReadLine();
                if (userGuess == compChoice)
                {
                    Console.WriteLine("You chose " + userGuess + " and the computer chose " + compChoice);
                    Console.WriteLine("It's a tie.");
                    tie++;
                }
                else if (userGuess == "r" && compChoice == "s")
                {
                    Console.WriteLine("You chose rock.");
                    Console.WriteLine("The computer chose scissors.");
                    Console.WriteLine("You win!");
                    win++;
                }
                else if (userGuess == "r" && compChoice == "p")
                {
                    Console.WriteLine("You chose rock.");
                    Console.WriteLine("The computer chose paper.");
                    Console.WriteLine("The computer wins!");
                    loss++;
                }
                else if (userGuess == "p" && compChoice == "r")
                {
                    Console.WriteLine("You chose paper.");
                    Console.WriteLine("The computer chose rock.");
                    Console.WriteLine("You win!");
                    win++;
                }
                else if (userGuess == "p" && compChoice == "s")
                {
                    Console.WriteLine("You chose paper.");
                    Console.WriteLine("The computer chose scissors.");
                    Console.WriteLine("The computer wins!");
                    loss++;
                }
                else if (userGuess == "s" && compChoice == "r")
                {
                    Console.WriteLine("You chose scissors.");
                    Console.WriteLine("The computer chose rock.");
                    Console.WriteLine("The computer wins!");
                    loss++;
                }
                else if (userGuess == "s" && compChoice == "p")
                {
                    Console.WriteLine("You chose scissors.");
                    Console.WriteLine("The computer chose paper.");
                    Console.WriteLine("You win!");
                    win++;
                }
                else
                {
                    Console.WriteLine("That is an invalid response.");
                }
            
                Console.WriteLine("The score is: " + win + " wins, " + loss + " losses, and " + tie + " tie games.");

                Console.WriteLine("Do you want to play again? Press y to play again and n to end game.");
                String playAgain = Console.ReadLine();
                if(playAgain == "y")
                {
                    playing = true;
                }else if(playAgain == "n")
                {
                    playing =false;
                }
                else
                {
                    Console.WriteLine("Invalid reponse, please type y or n.");
                }

            }
        }
    }
}
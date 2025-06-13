using System.Runtime.CompilerServices;

namespace _9
{
    //Lottery number generator and checker
    //Randomly generates 6 numbers between 1 and 49.
    //Can generate a bunch of different lottery tickets to see if any of them win.
    //Maybe like 1,000 random tickets and see if any match with the winning number.
    //Maybe later I will make a choice to check and see if you can manually enter a ticket number and see if its a winner
    internal class Program
    {
        static Random rand = new Random();
        static void Main(string[] args)
        {
            start();
        }

        static void start()
        {
            //Console.WriteLine("Do you want to pick your own numbers? Type yes/no");

            ////If you want to choose your own numbers you type them out
            //if (Console.ReadLine() == "yes")
            //{
            //    Console.WriteLine("Type the 6 numbers you want between 1 and 49. Do not make a space between each set of numbers.");
            //    string userNum = Console.ReadLine();
            //}
            //else
            //{
            //Console.WriteLine("Since you did not type yes, your ticket number will be randomly generated.");
            Console.WriteLine("How many tickets do you want to buy? Enter a number");

            //numOfTix is how many ticket the user wants to buy
            int numOfTix = Convert.ToInt32(Console.ReadLine());

            //creates a tixArray whose length is the number of tickets you want to buy
            int[,] tixArray = new int[numOfTix, 6];

            //For every ticket user wants to buy
            for (int i = 0; i < numOfTix; i++)
            {
                //Creates a new array that equals the new numberGenerator array
                int[] oneTicket = numberGenerator();

                //For every index in the inner array
                for (int j = 0; j < 6; j++)
                {
                    //The inner array index equals the oneTicket array, which is the random NumGenerator
                    tixArray[i, j] = oneTicket[j];
                }

            }

            //This is the winning numbers
            int[] winningNums = numberGenerator();

            //Calls the method that loops through all the "bought" tickets and sees if any win
            checksForWinner(numOfTix, winningNums, tixArray);
            //}
        }

        //Makes an array filled with lotter numbers
        static int[] numberGenerator()
        {
            int[] winningNums = new int[6];

            for (int i = 0; i < 6; i++)
            {
                winningNums[i] = rand.Next(1, 50);
            }
            return winningNums;
        }

        //Checks through all the "bought" tickets and sees if any match with the winning numbers
        static void checksForWinner(int numOfTix, int[] winningNums, int[,] tixArray)
        {

            bool foundWinner = false;

            //for every ticket bought
            for (int k = 0; k < numOfTix; k++)
            {
                //The ticket starts off as a winner
                bool isWinner = true;

                //Loops through all 6 sets of numbers
                for (int l = 0; l < 6; l++)
                {
                    //If any of the number sets don't match
                    if (tixArray[k, l] != winningNums[l])
                    {
                        //Winner is set to false. If we started as false and set it to true, then it would just think a winning number is where just 1 set of the 6 needs to be right to be a winner instead of all 6.
                        isWinner = false;
                        break;
                    }
                }
                //If all the numbers align
                if (isWinner)
                {
                    Console.WriteLine("You won! Ticket # " + (k + 1) + " is a winner");

                    //Sets the found winner to false
                    foundWinner = true;
                }

            }
            //If there is no winning ticket
            if (!foundWinner)
            {
                Console.WriteLine("Sorry you didn't win today. Maybe next time will be your lucky day!");
            }
        }

    }
}
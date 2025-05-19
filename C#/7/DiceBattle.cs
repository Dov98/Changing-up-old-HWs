namespace _7
{
    internal class DiceBattle
    {
        //Game where players roll the dice a certain number of times, and the player who has the highest total wins

        //Input players names
        //Ask how many rolls they want
        //Roll the dice
        //Declare the winner
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Players! Enter your nameplayer 1:");

            //input player names
            int player1 =  Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Player 1 is: " + player1);
            Console.WriteLine("Enter your nameplayer 2:");
            int player2 = Convert.ToInt16(Console.ReadLine());            
            Console.WriteLine("Player 2 is: " + player2);

            Console.WriteLine("How many times would you like to roll?");
            

            DiceRoller(player1);
            DiceRoller(player2);

            if(player1 > player2) //just realized that this only works if the players names are numbers
            {
                Console.WriteLine(player1 + " wins!");
            }else if(player1 < player2)
            {
                Console.WriteLine("Player " + player2 + " wins!");
            }
            else
            {
                Console.WriteLine("Tie game!");
            }

        }
        static int rollNum = Convert.ToInt32(Console.ReadLine());
        static Random rand = new Random();

        static void DiceRoller(int player)
        {
            //asking how many times they want to roll
            
            
            Console.WriteLine();

            //Rolling the inputed amount
            int addedRolls = 0;
            for (int i = 0; i < rollNum; i++)
            {
                //making sure there is no comma before the first iteration
                if (i != 0)
                {
                    Console.Write(", ");
                }

                int rolls = rand.Next(1, 7);
                Console.Write(rolls);

                addedRolls += rolls;
            }
            //Console.WriteLine("The rolls added up comes out to: " + addedRolls);
            Console.WriteLine("\nThe rolls for " + player + " added up comes out to: " + addedRolls);
        }
    }
}
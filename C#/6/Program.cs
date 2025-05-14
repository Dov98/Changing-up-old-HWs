namespace _6
{
    internal class Program
    {
        //Card Matching Game
        //make 2 arrays of matching cards shuffled
        //pick an index in each array to see if the cards match
        //it tells you what each card is in the index and if they match or not
        //if they match you get a point and the card is removed (which we did not learn yet at this point)
        //actually would need to make a list and not an array to remove items, which we did not learn yet, so i will just make this a random card matching game picker

        static void Main(string[] args)
        {
            string[] match1 = { "Apple", "Banana", "Carrot", "Date" };
            string[] match2 = { "Apple", "Banana", "Carrot", "Date" };

            //choosing random cards
            Random rand = new Random();
            int pick = rand.Next(0, 4);

            

            while (true)
            {
                //pick random cards
                string pick1 = match1[pick];

                pick = rand.Next(0, 4);
                string pick2 = match2[pick];


                Console.WriteLine("The first pick is: " + pick1 + ". And the second pick is: " + pick2);
                    if(pick1 == pick2)
                    {
                        Console.WriteLine("You have a match!");
                    }
                    else
                    {
                        Console.WriteLine("You do not have a match.");
                    }

                Console.WriteLine("Would you like to pick again?");
                if(Console.ReadLine() == "yes")
                {

                }
                else
                {
                    break;
                }
            }
            
        }
    }
}
namespace _8
{
    internal class BingoCardGenerator
    {
        //Generate 5x5 bingo card using a 2-D array. B: 1–15, I: 16–30, N: 31–45, G: 46–60, O: 61–75
        //I should start with 2 loops, one for 1-D and other for 2-D
        //I should fill the array with the letters, and maybe add 15 for each rand.next i do
        static void Main(string[] args)
        {
            CardMaker();
        }

        //Generates a bingo card
        static void CardMaker()
        {
            //Generates a 2D array of 5x5
            int[,] card = new int[5,5];

            //makes an array filled with bingo letters
            string[] bingo = { "B", "I", "N", "G", "O"};

            //Runs through the bingo array to print it out
            for (int k = 0; k < bingo.Length; k++)
            {
                Console.Write(bingo[k] + "  ");
            }
            Console.WriteLine();

            Random rand = new Random();

            //goes through the first dimension of the 2D card array (row)
            for (int i = 0; i < card.GetLength(0); i++)
            {
                
                //the i position on the leftmost location is what equals the letters
                //card[i,0] = bingo[i];
                //Console.Write(card[0, i]);
                //Console.Write(" ");

                //Sets a range for the columns since each column has a different range of numbers in bingo
                int min = 0;
                int max = 15;

                //Runs through the second array (columns)
                for (int j = 0; j < card.GetLength(1); j++)
                {
                    ////////////////////////////////////
                    ///need to figure out how to put bingo on top
                    /*if(j == 0)
                    {
                        Console.Write(bingo[i]);
                    }*/
                    
                    //card[j, 0] = bingo[i];
                    //Console.Write(card[j, 0]);
                    //Console.Write(rand.Next(25) + " ");

                    //Makeing the middle box stays free of numbers as per bingo rules
                    if(i == 2 && j == 2)
                    {
                        //Not enough room to write "free box"
                        Console.Write("fr ");

                        //This will make the inner loop skip the rest of the iteration
                        continue;
                    }

                    //In all other boxes, it writes a random value within the range we set
                    Console.Write(rand.Next(min, max) + " ");

                    //min and max going up resets after going through the columns becasue the changing of the 
                    //int doesn't take effect outside the inner loop.
                    min += 15;
                    max += 15;
                }
                
                //Prints the bingo card
                Console.WriteLine();
            }
            
        }
    }
}
namespace _10
{
    internal class TargetGuesser
    {
        //Game where you guess where random targets are placed.
        //I know the targets are visible. No one is playing for real right now. This is just for show.

        static char[,] board = new char[10,10];
        static Random rand = new Random();
        static void Main(string[] args)
        {
            //Sets the targets
            targetSetter();

            //Prints the board
            boardPrinter();

            //Player guesses where the targets are
            guessPlace();

            //Prints the board a second time so you can see where you guessed and how close they were to the targets
            boardPrinter();
        }

        //Prints the 2-D array board
        static void boardPrinter()
        {
            //Printing out the 2-D array
            for (int row = 0; row < board.GetLength(0); row++)
            {
                for (int col = 0; col < board.GetLength(1); col++)
                {
                    //If the index does not have a value
                    if(board[row,col] == '\0')
                    {
                        //Print the blank dash
                        Console.Write("- ");
                    }
                    else
                    {
                        //If the index does have a value print the value
                        Console.Write(board[row, col] + " ");
                    }
                    
                }
                Console.WriteLine();
            }
        }

        //Sets up targets at random in the 2-D array
        static void targetSetter()
        {
            //Prints 10 targets randomly troughout the board
            for (int j = 0; j < 10; j++)
            {
                int i = rand.Next(board.GetLength(0));
                int k = rand.Next(board.GetLength(1));
                board[i, k] = 'T';
            }
            
        }

        //User guesses where the target could be
        static void guessPlace()
        {
            //Starts counting correct guesses
            int cg = 0;

            Console.WriteLine("Guess where the targets are hiding.");

            //Runs the guessing game for 5 rounds
            for (int i = 0; i < 5; i++)
            {
                
                Console.WriteLine("Enter a row number between 0-9");

                //Takes the row
                int row = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter a col number between 0-9");

                //Takes the column
                int col = Convert.ToInt32(Console.ReadLine());

                //If the guess is out of the bounds of the array it breaks out of the loop.
                if (row < 0 || row >= board.GetLength(0) || col < 0 || col >= board.GetLength(1))
                {
                    Console.WriteLine("Invalid coordinates. Try again.");
                    return;
                }

                //If the coordinates you guessed equal a target, you have 1 correct, the cg counter goes up by 1, and it prints a G where you guessed
                if (board[row, col] == 'T')
                {
                    Console.WriteLine("You guessed right! There is a mark there.");
                    board[row, col] = 'G';
                    cg++;
                }
                //If you didn't guess right it places a G where you guessed
                else
                {
                    Console.WriteLine("Sorry, no target there.");
                    board[row, col] = 'G';
                }
            }

            Console.WriteLine("Out of Guesses!");
            Console.WriteLine("The amount of times you guessed the target correctly is " + cg);
            Console.WriteLine("Here are where the targets were hiding:");



        }
    }
}
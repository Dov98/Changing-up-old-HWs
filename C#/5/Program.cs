namespace _5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //going to make mutiplication table with methods
            //user enters what range they want the table to be, and then it spits out result

            Console.WriteLine("Welcome to the Multiplication Table Generator!\nEnter a row length for the table you want generated.");
            int r = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Great, now enter a column length");
            int l = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nGot it. Here is your table:\n");

            multiplicationTable(r,l);
        }
        static void multiplicationTable(int i, int j)
        {
            for(int row = 1; row <= i; row++)
            {

                for (int col = 1; col <= j; col++)
                {
                    Console.Write(row*col + " ");
                    if((row*col) < 10)
                    {
                        Console.Write("  ");
                    }else if ((row * col) < 100)
                    {
                        Console.Write(" ");
                    }

                }
                Console.WriteLine();
            }
        }

    }
}
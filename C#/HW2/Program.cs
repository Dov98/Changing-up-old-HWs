namespace HW2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //making a rudimentary uppercase maker
            //could not figure out how to make one with current tools learned
            //I wanted to make a loop of each number after "l" so I would not have to write it 5 times, but did not learn loops yet at this moment.
            //char l = 'l';
            char l1 = 'g';
            char l2 = 'r';
            char l3 = 'e';
            char l4 = 'a';
            char l5 = 't';

            char upCase1 = (char)(l1 - 32);
            char upCase2 = (char)(l2 - 32);
            char upCase3 = (char)(l3 - 32);
            char upCase4 = (char)(l4 - 32);
            char upCase5 = (char)(l5 - 32);
            Console.Write((char)(upCase1));
            Console.Write((char)upCase2);
            Console.Write((char)upCase3);
            Console.Write((char)upCase4);
            Console.WriteLine((char)upCase5);
            
        }
    }
}
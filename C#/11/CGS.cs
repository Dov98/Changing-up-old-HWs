namespace _11
{
    internal class CGS
    {
        //Class Grading System
        //Array of 5 students. Each student has an array of 5 test scores
        //------------------------------------------------------------------------- Maybe I'll do the next thing another time
        //Get the avg score, highest and lowest, and letter grade based off average

        //I am thinking to make an array of names, and then for each student in the array, make a random array of 5 test scores
        
        static Random rand = new Random();
        //Have to declare a name so I can use it in CGS Tester
        public string name;
        //Makes an array that will be filled with scores
        public int[] scores = new int[5];


        //Makes and writes an array of scores for each student
        public void Scores()
        {
            //Makes random test scors between 60 and 100 and assigns it to spots on the scores array
            for (int i = 0; i < scores.Length; i++)
            {
                scores[i] = rand.Next(60,101);
            }

            for (int i = 0; i < scores.Length; i++)
            {
                //Writes out each test score in the array
                Console.Write(scores[i]);

                //If i is less than the score array length -1, then it prints a comman.
                //So it doesn't print a comma on the last one.
                if (i < scores.Length - 1)
                {
                    Console.Write(", ");
                }

                
            }
        }
    }
}
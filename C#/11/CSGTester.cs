using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11
{
    internal class CSGTester
    {
        static string[] students = { "John", "Jim", "Jenny", "Jolly", "Jimberly"};
        static void Main(string[] args)
        {
            //This is needed to keep the array of student scores
            CGS[] c = new CGS[students.Length];
                
            for (int i = 0; i < students.Length; i++)
            {
                //Creates new CSG
                c[i] = new CGS();

                //Writes the students name
                Console.Write($"{students[i]}'s scores: ");
                //Calls the scores method which makes an array of 5 test scores
                c[i].Scores();

                Console.WriteLine();
            }

        }
    }
}

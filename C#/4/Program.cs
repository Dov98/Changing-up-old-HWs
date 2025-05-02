namespace _4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String userInput;
            do
            {

                Console.WriteLine("Enter your grade and I will tell you your GPA.");

                int grade = Convert.ToInt32(Console.ReadLine());

                if (grade >= 94)
                {
                    Console.WriteLine("Your GPA is 4.0");
                }
                else if (grade >= 90)
                {
                    Console.WriteLine("Your GPA is 3.7.");
                }
                else if (grade >= 87)
                {
                    Console.WriteLine("Your GPA is 3.3.");
                }
                else if (grade >= 83)
                {
                    Console.WriteLine("Your GPA is 3.0.");
                }
                else if (grade >= 80)
                {
                    Console.WriteLine("Your GPA is 2.7.");
                }
                else if (grade >= 77)
                {
                    Console.WriteLine("Your GPA is 2.3.");
                }
                else if (grade >= 73)
                {
                    Console.WriteLine("Your GPA is 2.0.");
                }
                else if (grade >= 70)
                {
                    Console.WriteLine("Your GPA is 1.7.");
                }
                else if (grade >= 67)
                {
                    Console.WriteLine("Your GPA is 1.3.");
                }
                else if (grade >= 60)
                {
                    Console.WriteLine("Your GPA is 1.0.");
                }
                else if (grade >= 0)
                {
                    Console.WriteLine("Your GPA is 0.0.");
                }

                Console.WriteLine("Do you want to enter another grade? Enter yes/no");
                userInput = Console.ReadLine();
            }
            while (userInput == "yes");
        }
    }
    
}
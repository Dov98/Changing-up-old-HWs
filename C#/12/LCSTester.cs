namespace _12
{
    internal class LCSTester
    {
        static void Main(string[] args)
        {
            Book b1 = new Book();
            Book b2 = new Book();

            b1.title = "Cloudy with a chance of meatballs";
            b1.author = "Judy Barrett";
            b1.ID = "JB123";
            b1.genre = "Children";

            b2.title = "Cat in the Hat";
            b2.author = "Dr. Seuss";
            b2.ID = "DS321";
            b2.genre = "Children";

            Book b3 = new Book();
            b3.title = "Lord of the Rings";
            b3.author = "John Ronald Reuel Tolkien";
            b3.ID = "JRRT213";
            b3.genre = "Fantasy";

            b1.Print();
            b2.Print();
            b3.Print();


            //Borrow Limit
            int BL = 3;

            Student s1 = new Student();
            s1.name = "John Doe";
            s1.bookList = new String[BL];
            s1.bookList[0] = "DS321";

            s1.Print();
        }
    }
}
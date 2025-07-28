using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12
{
    //Was planning on adding more to the library checkout system, such as removing books from the list when someone has one,
    //and making a library class that will print all the studets and their books, but had to move on for other reasons.
    //Maybe will come back to this, but probs not.
    internal class LCS
    {
    }

    internal class Book
    {
        public string title;
        public string author;
        public string ID;
        public string genre;

        public string TheTitle
        {
            get { return title; }
            set { title = value; }
        }

        public string TheAuthor
        {
            get { return author; }
            set { author = value; }
        }

        public string TheID
        {
            get { return ID; }
            set { ID = value; }
        }

        public string TheGenre
        {
            get { return genre;  }
            set { genre = value; }
        }

        public void Print()
        {
            Console.WriteLine($"{TheTitle}, {TheAuthor}, {TheID}, {TheGenre}");
        }
    }

    internal class Student
    {
        //Has a list of borrowed books
        public string name;
        public string[] bookList;

        public void Print()
        {
            Console.Write($"Name: {name}, Current books borrowed: ");
            foreach (var book in bookList)
            {if(book == null)
                {
                    continue;
                }
                Console.Write(book);
            }
        }
    }

    internal class Library
    {
        //Holds a list of borrrowed books and student
    }
}

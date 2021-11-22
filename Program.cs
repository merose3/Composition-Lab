using System;

namespace Composition_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            Author myAuthor = new Author("Jeff Lucas", 'm', "jslucas@cba.ua.edu");
            Console.WriteLine(myAuthor.ToString());
            Console.WriteLine("\n");
            

            Book myBook = new Book("12243", "My Book, Your Book", myAuthor);
            Console.WriteLine(myBook.ToString());
            Console.WriteLine("\n");

            Console.WriteLine(myBook.GetAuthor().ToString());

            
            Book yourBook = new Book("4321", "The Phantom Book", new Author("Jamie", 'f', "jamie@mail.com"));
            Console.WriteLine(yourBook.ToString());
            System.Console.WriteLine("\n");
            Author yourAuthor = new Author("Jamie", 'f', "jamie@crimson.ua.edu");
            //Console.WriteLine(yourAuthor.GetEmail() + " ");
            Console.WriteLine("\n");
            yourBook.GetAuthor().SetEmail("jamie@crimson.ua.edu");
           
            Console.WriteLine(yourBook.ToString());
        }
    }
}

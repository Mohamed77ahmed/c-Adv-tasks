using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment4
{
    public class Book
    {


        public string ISBN { get; set; }
        public string Title { get; set; }
        public string[] Author { get; set; }
        public DateTime PublicationDate { get; set; }
        public decimal Price { get; set; }


        public Book(string iSBN, string title, string[] author, DateTime publicationDate, decimal price)
        {
            ISBN = iSBN;
            Title = title;
            Author = author;
            PublicationDate = publicationDate;
            Price = price;
        }


        public override string ToString()
        {
            return $"ISBN {ISBN} ,Title {Title} , Author {Author} , PublicationDate {PublicationDate} , Price {Price}";
        }

    }


    public class BookFunctions
    {

        public static string GetTitle(Book B)
        {
            return B.Title;
        }

        public static string GetAuthors(Book B)
        {
            return string.Join(", ", B.Author);
        }

        public static string GetPrice(Book B)
        {
            return B.Price.ToString("C");
        }




    }



    public delegate string BookDelegate(Book b);



    public class LibraryEngine
    {
        public static void ProcessBooks(List<Book> bList, BookDelegate fPtr)
        {
            foreach (Book b in bList)
            {
                Console.WriteLine(fPtr(b));
            }
        }


        public static void ProcessBooks(List<Book> bList, Func<Book, string> fPtr)
        {
            foreach (Book b in bList)
            {
                Console.WriteLine(fPtr(b));
            }
        }

    }
}

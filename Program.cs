using static System.Reflection.Metadata.BlobBuilder;

namespace assignment4
{
    internal class Program
    {
        static void Main(string[] args)
        {


            List<Book> books = new List<Book>()
        {
            new Book("111", "C#", new string[]{"nada", "Sama"}, new DateTime(2025,5,1), 300),
            new Book("222", "Advanced C#", new string[]{"Mohammed"}, new DateTime(2011,3,15), 500m)
        };



            LibraryEngine.ProcessBooks(books, new BookDelegate(BookFunctions.GetTitle));


            Console.WriteLine("---------------------------------------------");

            LibraryEngine.ProcessBooks(books, new BookDelegate(BookFunctions.GetAuthors));



        }
    }
}

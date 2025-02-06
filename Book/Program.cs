using System.Net.Http.Headers;
using System.Linq;

namespace Book
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Book> bookcase = new List<Book>();
            bookcase.Add(new Book(500));
            bookcase.Add(new Book(250));

            Console.WriteLine("Please enter the amount of pages of the book that you are currently reading");
            bookcase.Add(new Book(Convert.ToInt32(Console.ReadLine())));

            Console.WriteLine("The total amount of all the pages are:" + Book.TotalPages(bookcase));
            Console.WriteLine("The average of all the books are:" + Book.AveragePages(bookcase));
            Console.WriteLine("The book with the most amount of pages: " + Book.BiggestBook(bookcase).pages);
        }

}
        
    internal class Book
    {
        public int pages;
        
        public static int TotalPages(List<Book> books)
        {
            int total = 0;
            foreach (Book book in books)
            {
                total += book.pages;
            }
            return total;
        }

        public static double AveragePages(List<Book> books)
        {
            double total = 0;
            foreach (Book book in books)
            {
                total += book.pages;
            }
            return total / books.Count();
        }

        public static Book BiggestBook(List<Book> books)
        {
            Book biggest = books.FirstOrDefault(new Book());
            foreach (Book book in books)
            {
                if (book.pages > biggest.pages)
                {
                    biggest = book;
                }
            }
            return biggest;
        }

       
        public Book()
        {
            pages = 0;
        }
        public Book(int pages)
        {
            this.pages = pages;

        }

    }

}

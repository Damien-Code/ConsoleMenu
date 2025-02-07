using System.Net.Http.Headers;
using System.Linq;

namespace Book
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Book> bookcase = new List<Book>();
            bookcase.Add(new Book("Atomic Habits", 500));
            bookcase.Add(new Book("Harry potter", 250));

            Console.WriteLine("Please enter the amount of pages of the book that you are currently reading");
            bookcase.Add(new Book(Console.ReadLine(), Convert.ToInt32(Console.ReadLine())));

            Console.WriteLine($"The total amount of all the pages:  { Book.TotalPages(bookcase) }");
            Console.WriteLine("The average pages of all the books are:" + Book.AveragePages(bookcase));
            Console.WriteLine($"The book with the most amount of pages: {Book.BiggestBook(bookcase).pages} {Book.BiggestBook(bookcase).title}");
            Console.WriteLine($"The title of your book: {Book.BookTitle(bookcase).title}");
        }

}
        
    internal class Book
    {
        public string title;
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

        public static Book BookTitle(List<Book> books)
        {
            Book book = books.LastOrDefault();
            return book;

        }

       
        public Book()
        {
            title = "Book 1";
            pages = 50;
        }
        public Book(string title, int pages)
        {
            this.title = title;
            this.pages = pages;

        }

    }

}

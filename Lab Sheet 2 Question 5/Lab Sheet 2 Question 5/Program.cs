namespace Lab_Sheet_2_Question_5
{
    internal class LibraryBook
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public bool Available { get; set; }

        public LibraryBook(string title, string author, bool available)
        {
            Title = title;
            Author = author;
            Available = available;
        }

        public void BorrowBook()
        {
            Available = false;
        }

        public void ReturnBook()
        {
            Available = true;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<LibraryBook> library = new List<LibraryBook>();

            Console.WriteLine("Welcome to the Library!");
            Console.WriteLine("Current Library Status:\n");
            DisplayLibraryStatus(library);

            Console.WriteLine("\nBorrowing a book...");
            BorrowBook(library, "Book Title");

            Console.WriteLine("\nUpdated Library Status:\n");
            DisplayLibraryStatus(library);

            Console.WriteLine("\nReturning a book...");
            ReturnBook(library, "Book Title");

            Console.WriteLine("\nUpdated Library Status:\n");
            DisplayLibraryStatus(library);
        }

        static void DisplayLibraryStatus(List<LibraryBook> library)
        {
            foreach (var book in library)
            {
                Console.WriteLine($"Title: {book.Title}, Author: {book.Author}, Available: {book.Available}");
            }
        }

        static void BorrowBook(List<LibraryBook> library, string title)
        {
            var book = library.Find(b => b.Title == title);
            if (book != null && book.Available)
            {
                book.BorrowBook();
                Console.WriteLine($"You have successfully borrowed '{title}'.");
            }
            else
            {
                Console.WriteLine($"Sorry, '{title}' is not available for borrowing.");
            }
        }

        static void ReturnBook(List<LibraryBook> library, string title)
        {
            var book = library.Find(b => b.Title == title);
            if (book != null && !book.Available)
            {
                book.ReturnBook();
                Console.WriteLine($"You have successfully returned '{title}'.");
            }
            else
            {
                Console.WriteLine($"'{title}' is already available in the library.");
            }
        }
    }
}
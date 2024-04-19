namespace Lab_Sheet_2_Question_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book();

            book.Title = "The Great Gatsby";
            book.Author = "F. Scott Fitzgerald";

            Console.WriteLine($"Book Title: {book.Title}");
            Console.WriteLine($"Book Author: {book.Author}");
        }
    }

    class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
    }
}

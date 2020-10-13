using System;

namespace LibraryWorker
{
    public class LibraryService
    {
        public void Borrow(Book book)
        {
            Console.WriteLine($"Book {book.Title} by {book.Author}");
        }
    }
}
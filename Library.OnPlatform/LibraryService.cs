using Microsoft.Extensions.Logging;

namespace Library.OnPlatform
{
    public class LibraryService
    {
        private readonly ILogger<LibraryService> _logger;

        public LibraryService(ILogger<LibraryService> logger)
        {
            _logger = logger;
        }

        public void Borrow(Book book)
        {
            _logger.LogInformation("Book {Title} by {Author}", book.Title, book.Author);
        }
    }
}
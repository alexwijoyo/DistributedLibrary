using System.Threading.Tasks;
using LibraryContracts;
using MassTransit;

namespace LibraryWorker
{
    public class BorrowBookConsumer : IConsumer<BorrowBook>
    {
        private readonly LibraryService _libraryService;

        public BorrowBookConsumer(LibraryService libraryService)
        {
            _libraryService = libraryService;
        }

        public async Task Consume(ConsumeContext<BorrowBook> context)
        {
            var msg = context.Message;
            var book = new Book(msg.Title, msg.Author, msg.Content);
            _libraryService.Borrow(book);
            await context.RespondAsync<Accepted>(new { TimeStamp = InVar.Timestamp });
        }
    }
}
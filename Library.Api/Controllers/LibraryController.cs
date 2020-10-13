using System.Threading.Tasks;
using LibraryContracts;
using MassTransit;
using Microsoft.AspNetCore.Mvc;

namespace LibraryApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LibraryController : ControllerBase
    {
        private readonly IRequestClient<BorrowBook> _requestClient;

        public LibraryController(IRequestClient<BorrowBook> requestClient)
        {
            _requestClient = requestClient;
        }

        [HttpPost]
        public async Task<IActionResult> Borrow(BookDto book)
        {
            await _requestClient.GetResponse<Accepted>(new
            {
                book.Title,
                book.Author,
                book.Content
            });

            return Ok();
        }
    }
}

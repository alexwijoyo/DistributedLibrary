using System;
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
        private readonly ISendEndpointProvider _sendEndpointProvider;
        public LibraryController(ISendEndpointProvider sendEndpointProvider)
        {
            _sendEndpointProvider = sendEndpointProvider;
        }

        [HttpPost]
        public async Task<IActionResult> Borrow(BookDto book)
        {
            var endpoint = await _sendEndpointProvider.GetSendEndpoint(new Uri("exchange:borrow-book"));
            await endpoint.Send<BorrowBook>(new
            {
                book.Title,
                book.Author,
                book.Content
            });

            return Accepted();
        }
    }
}

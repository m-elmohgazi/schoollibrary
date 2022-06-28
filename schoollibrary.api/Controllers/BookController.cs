using Microsoft.AspNetCore.Mvc;
using schoollibrary.service;

namespace schoollibrary.api.Controllers
{
    [ApiController]
    [Route("book")]
    public class BookController : ControllerBase
    {
        private readonly IBookService _bookService;
        public BookController(IBookService bookService)
        {
            _bookService= bookService;
        }

        [HttpGet]
        [Route("books-list/author/{authorSerial}")]
        public IActionResult GetBooksListOfSepcificAuthor(decimal authorSerial)
        {
            var books = _bookService.GetBooksListOfSepcificAuthor(authorSerial);
            return Ok(books);
        }
    }
}
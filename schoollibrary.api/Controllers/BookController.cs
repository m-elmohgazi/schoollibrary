using Microsoft.AspNetCore.Mvc;

namespace schoollibrary.api.Controllers
{
    [ApiController]
    [Route("book")]
    public class BookController : ControllerBase
    {
        public BookController()
        {
        }

        [HttpGet]
        [Route("books-list/author/{serial}")]
        public IActionResult GetBooksListOfSepcificAuthor(decimal serial)
        {
            return Ok();
        }
    }
}
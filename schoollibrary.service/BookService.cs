using schoollibrary.data;
using schoollibrary.domain;

namespace schoollibrary.service
{
    public class BookService:IBookService
    {
        private readonly IBookRepository _bookRepository;
        public BookService(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        public IEnumerable<Book> GetBooksListOfSepcificAuthor(decimal authorSerial)
        {
           return _bookRepository.GetBooksListOfSepcificAuthor(authorSerial);
        }
    }
}
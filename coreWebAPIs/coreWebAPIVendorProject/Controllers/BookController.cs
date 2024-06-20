using coreWebAPIVendorProject.DAL;
using coreWebAPIVendorProject.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace coreWebAPIVendorProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private BookRepository _bookRepository;
        public BookController()
        {
            _bookRepository = new BookRepository();
        }

        // Request Url: http://localhost:5019/api/Book
        [HttpGet]
        public ActionResult<IEnumerable<Book>> Get()
        {
            return _bookRepository.GetAllBook();
        }

        // Request Url: http://localhost:5019/api/Book/1
        [HttpGet("{id}")]
        public ActionResult<Book> Get(int id)
        {
            return _bookRepository.GetBook(id);
        }

        [HttpPost]
        public ActionResult<Book> Create(Book book)
        {
            _bookRepository.AddBook(book);
            return CreatedAtAction(nameof(Get), new { id = book.Id }, book);
        }

        [HttpPut("{id}")]
        public ActionResult Update(int id, Book book)
        {
            if (id != book.Id)
            {
                return BadRequest();
            }
            var existingBook = _bookRepository.GetBook(id);
            if (existingBook == null) return NotFound();
            _bookRepository.UpdateBook(book);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var book = _bookRepository.GetBook(id);
            if (book == null) return NotFound();
            _bookRepository.DeleteBook(id);
            return NoContent();
        }
    }
}

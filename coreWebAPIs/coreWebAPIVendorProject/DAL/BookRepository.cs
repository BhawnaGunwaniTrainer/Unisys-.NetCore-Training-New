using coreWebAPIVendorProject.Models;

namespace coreWebAPIVendorProject.DAL
{
    public class BookRepository: IBookRepository
    {
        private static List<Book> _books = new List<Book>()
            {
               new Book() { Id = 1, Name = "Book 1", Author = "Ratna Sagar", Year = 2001 },
               new Book() { Id = 2, Name = "Book 2", Author = "William Smith", Year = 2002 }
            };
     

        public List<Book> GetAllBook() => _books;

        public Book GetBook(int id) => _books.FirstOrDefault(b => b.Id == id);

        public void AddBook(Book book)
        {
            book.Id = _books.Max(x => x.Id) + 1;
            _books.Add(book);
        }

        public void UpdateBook(Book book)
        {
            var existingBook = GetBook(book.Id);
            if (existingBook == null) return;

            existingBook.Name = book.Name;
            existingBook.Author = book.Author;
            existingBook.Year = book.Year;

        }

        public void DeleteBook(int id)
        {
            var existingBook = GetBook(id);
            if (existingBook == null) return;
            _books.Remove(existingBook);
        }
    }
}

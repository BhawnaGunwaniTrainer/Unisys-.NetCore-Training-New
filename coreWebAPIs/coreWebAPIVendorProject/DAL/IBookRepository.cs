using coreWebAPIVendorProject.Models;

namespace coreWebAPIVendorProject.DAL
{
    public interface IBookRepository
    {
        public List<Book> GetAllBook();
        public Book GetBook(int id);
        public void AddBook(Book book);
        public void UpdateBook(Book book);
        public void DeleteBook(int id);
    }
}

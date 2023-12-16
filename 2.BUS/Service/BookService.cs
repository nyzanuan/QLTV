using _1.DAL.IRepository;
using _1.DAL.Model;
using _1.DAL.Repository;
using _2.BUS.IService;
using Sharing.ReturnModel;

namespace _2.BUS.Service
{
    public class BookService : IBookService
    {
        private readonly IBookRepository _bookRepository;
        public BookService()
        {
            _bookRepository = new BookRepository();
        }

        public bool AddBook(Book book)
        {
            return _bookRepository.AddBook(book);
        }

        public bool DeleteBook(int id)
        {
            return _bookRepository.DeleteBook(id);
        }


        public ValueReturn GetAllBook(int pageIndex, int pageSize, string? search)
        {
            try
            {
                ValueReturn result = _bookRepository.GetAllBook(pageIndex, pageSize, search);
                return result;
            }
            catch (Exception ex)
            {
                return new ValueReturn()
                {
                    Message = ex.Message,
                    Status = false,
                    Value = new DataReturn
                    {
                        TotalElemnent = 0,
                        ListElemnent = Array.Empty<Customer>(),
                    }

                };
            }
        }
        public List<Author> GetAllAuthor(string? search)
        {
            return _bookRepository.GetAllAuthor(search);
        }
        public List<Category> GetAllCategory(string? search)
        {
            return _bookRepository.GetAllCategory(search);
        }

        public List<Language> GetAllLanguage(string? search)
        {
            return _bookRepository.GetAllLanguage(search);
        }

        public List<Publisher> GetAllPublisher(string? search)
        {
            return _bookRepository.GetAllPublisher(search);
        }

        public Book GetBook(int id)
        {
            return _bookRepository.GetBook(id);
        }

        public bool UpdateBook(Book book)
        {
            return (_bookRepository.UpdateBook(book));
        }

        public List<Book> GetAllBook()
        {
            return _bookRepository.GetAllBook();
        }
    }
}

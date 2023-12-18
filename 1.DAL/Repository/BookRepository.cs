using _1.DAL.Data;
using _1.DAL.IRepository;
using _1.DAL.Model;
using Microsoft.EntityFrameworkCore;
using Sharing.ReturnModel;

namespace _1.DAL.Repository
{
    public class BookRepository : IBookRepository
    {
        public readonly DataContext _dataContext;
        public BookRepository()
        {
            _dataContext = new DataContext();
        }
        public bool SaveData()
        {
            var result = _dataContext.SaveChanges() > 0;
            return result;
        }
        public bool AddBook(Book book)
        {
            try
            {
                _dataContext.Book.Add(book);
                return SaveData();
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public bool DeleteBook(int id)
        {
            try
            {
                var book = _dataContext.Book.FirstOrDefault(p => p.BookId == id);
                _dataContext.Book.Remove(book);
                return SaveData();
            }
            catch
            {
                return false;
            }
        }

        public ValueReturn GetAllBook(int pageIndex, int pageSize, string? search)
        {
            try
            {
                var query = _dataContext.Book.Include(p => p.Category).AsQueryable();
                if (!string.IsNullOrEmpty(search))
                {
                    string searchWithoutDiacritics = search.ToLower();
                    query = query.Where(p =>
                        p.Name.ToLower().Contains(searchWithoutDiacritics)
                    );
                }


                return new ValueReturn()
                {
                    Status = true,
                    Value = new DataReturn()
                    {
                        ListElemnent = query.Skip((pageIndex - 1) * pageSize).Take(pageSize).ToList(),
                        TotalElemnent = query.Count()
                    }

                };
            }
            catch (Exception ex)
            {
                return new ValueReturn()
                {
                    Message = ex.Message,
                    Status = false,
                    Value = new DataReturn()
                    {
                        ListElemnent = Array.Empty<Category>(),
                        TotalElemnent = 0

                    }
                };
            }
        }

        public Book GetBook(int id)
        {
            var rs = _dataContext.Book
                    .Join(_dataContext.Category, b => b.CategoryId, c => c.CategoryId,
                            (b, c) => new { Book = b, Category = c })
                    .Join(_dataContext.Publisher, bc => bc.Book.PublisherId, p => p.PublisherId,
                            (bc, p) => new { Book = bc.Book, Category = bc.Category, Publisher = p })
                    .Join(_dataContext.Language, bcp => bcp.Book.LanguageId, l => l.LanguageId,
                            (bcp, l) => new { Book = bcp.Book, Category = bcp.Category, Publisher = bcp.Publisher, Language = l })
                    .Join(_dataContext.Author, bcpl => bcpl.Book.AuthorId, a => a.AuthorId,
                            (bcpl, a) => new Book()
                            {
                                BookId = bcpl.Book.BookId,
                                Name = bcpl.Book.Name,
                                Title = bcpl.Book.Title,
                                AuthorId = a.AuthorId,
                                Author = new Author() { Name = a.Name },
                                CategoryId = bcpl.Category.CategoryId,
                                Category = new Category() { Name = bcpl.Category.Name },
                                PublisherId = bcpl.Publisher.PublisherId,
                                Publisher = new Publisher() { Name = bcpl.Publisher.Name },
                                LanguageId = bcpl.Language.LanguageId,
                                Language = new Language() { Name = bcpl.Language.Name },
                                Image = bcpl.Book.Image,
                                Status = bcpl.Book.Status,
                                AvailableCopies = bcpl.Book.AvailableCopies,
                                BorrowedCopies = bcpl.Book.BorrowedCopies,
                            })
                    .Where(b => b.BookId == id)
                    .FirstOrDefault();
            if (rs != null)
                return rs as Book;
            else
                return new Book();
        }

        public bool UpdateBook(Book book)
        {
            try
            {
                var bookData = _dataContext.Book.FirstOrDefault(p => p.BookId == book.BookId);
                if (bookData != null)
                {
                    bookData.Title = book.Title;
                    bookData.Name = book.Name;
                    bookData.AuthorId = book.AuthorId;
                    bookData.CategoryId = book.CategoryId;
                    bookData.PublisherId = book.PublisherId;
                    bookData.LanguageId = book.LanguageId;
                    bookData.AvailableCopies = book.AvailableCopies;
                    bookData.TotalCopies = book.TotalCopies;
                    bookData.Image = book.Image;
                    bookData.Status = book.Status;
                    return SaveData();
                }
                else
                {
                    return false;
                }
            }

            catch { return false; }
        }

        public List<Author> GetAllAuthor(string? search)
        {
            try
            {
                var query = _dataContext.Author.AsQueryable();
                if (!string.IsNullOrEmpty(search))
                {
                    string searchLower = search.ToLower();
                    query = query.Where(x => x.Name.ToLower().Contains(searchLower) || x.AuthorId.ToString() == search);
                }
                return query.ToList();
            }
            catch
            {
                return new List<Author>();
            }
        }

        public List<Language> GetAllLanguage(string? search)
        {
            try
            {
                var query = _dataContext.Language.AsQueryable();
                if (!string.IsNullOrEmpty(search))
                {
                    string searchLower = search.ToLower();
                    query = query.Where(x => x.Name.ToLower().Contains(searchLower) || x.LanguageId.ToString() == search);
                }
                return query.ToList();
            }
            catch
            {
                return new List<Language>();
            }
        }

        public List<Category> GetAllCategory(string? search)
        {
            try
            {
                var query = _dataContext.Category.AsQueryable();
                if (!string.IsNullOrEmpty(search))
                {
                    string searchLower = search.ToLower();
                    query = query.Where(x => x.Name.ToLower().Contains(searchLower) || x.CategoryId.ToString() == search);
                }
                return query.ToList();
            }
            catch
            {
                return new List<Category>();
            }
        }

        public List<Publisher> GetAllPublisher(string? search)
        {
            try
            {
                var query = _dataContext.Publisher.AsQueryable();
                if (!string.IsNullOrEmpty(search))
                {
                    string searchLower = search.ToLower();
                    query = query.Where(x => x.Name.ToLower().Contains(searchLower) || x.PublisherId.ToString() == search);
                }
                return query.ToList();
            }
            catch
            {
                return new List<Publisher>();
            }
        }

        public List<Book> GetAllBook()
        {
            return _dataContext.Book.Take(20).ToList();
        }
    }
}

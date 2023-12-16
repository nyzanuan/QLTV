using _1.DAL.Model;
using Sharing.ReturnModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.IRepository
{
    public interface IBookRepository
    {
        bool AddBook(Book book);
        bool DeleteBook(int id);
        bool UpdateBook(Book book);
        Book GetBook(int id);
        ValueReturn GetAllBook(int pageIndex, int pageSize, string? search);
        List<Author> GetAllAuthor(string? search);
        List<Language> GetAllLanguage(string? search);
        List<Category> GetAllCategory(string? search);
        List<Publisher> GetAllPublisher(string? search);
        List<Book> GetAllBook();
    }
}

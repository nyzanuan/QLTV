using _1.DAL.Model;
using Sharing.ReturnModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.IRepository
{
    public interface IAuthorRepository
    {
        ValueReturn GetAllAuthor(int pageIndex, int pageSize, string? search);
        bool UpdateAuthor(Author author);
        bool SaveData();
        bool DeleteAuthor(int maTacGia);
        bool AddAuthor(Author newTacgia);
    }
}

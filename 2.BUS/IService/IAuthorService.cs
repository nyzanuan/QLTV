using _1.DAL.Model;
using Sharing.ReturnModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.IService
{
    public interface IAuthorService
    {
        bool AddAuthor(Author newTacgia);
        bool DeleteAuthor(int maTacGia);
        ValueReturn GetAllAuthor(int pageIndex, int pageSize, string? search);
        bool UpdateAuthor(Author author);
    }
}

using _1.DAL.Model;
using Sharing.ReturnModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.IRepository
{
    public interface ICategoryRepository
    {
        bool AddCategory(Category category);
        bool DeleteCategory(int id);
        bool UpdateCategory(Category category);
        Category GetCategory(int id);
        ValueReturn GetAllCategory(int pageIndex, int pageSize, string? search);
    }
}

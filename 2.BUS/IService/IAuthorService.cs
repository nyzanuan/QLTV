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
        ValueReturn GetAllAuthor(int pageIndex, int pageSize, string? search);
    }
}

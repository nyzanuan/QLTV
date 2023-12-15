using _1.DAL.Model;
using Sharing.ReturnModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.IRepository
{
    public interface INXBRepository
    {
        ValueReturn GetAllPub(int pageIndex, int pageSize, string? search);
        bool UpdatePub(Publisher publisher);
        bool DeletePub(int id);
        bool AddPub(Publisher publisher);
    }
}

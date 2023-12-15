using _1.DAL.Model;
using Sharing.ReturnModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.IService
{
    public interface INXBService
    {
        ValueReturn GetAllPub(int pageIndex, int pageSize, string? search);
        bool UpdatePub(Publisher publisher);
        bool DeletePub(int id);
        bool AddPub(Publisher publisher);
    }
}

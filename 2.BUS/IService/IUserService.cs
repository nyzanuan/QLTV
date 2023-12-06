using _1.DAL.Model;
using Sharing.ReturnModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.IService
{
    public interface IUserService
    {
        Task<ValueReturn> AddUser(User user);
        bool DeleteUser(int maTacGia);
        ValueReturn GetAllUser(int pageNow, int pageSize, string? search, int isAdmin);
        Task<ValueReturn> UpdateUser(User user);
        ValueReturn Validate(string userName, string password);

    }
}

using _1.DAL.Model;
using Sharing.ReturnModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.IRepository
{
    public interface IUserRepository
    {
        Task<ValueReturn> AddUser(User user);
        bool DeletedUser(int userId);
        Task<ValueReturn> UpdateUser(User user);
        ValueReturn GetUser (string username, string password);
        ValueReturn GetAllUsers(int pageNow, int pageSize, string? search, int isAdmin);
    }
}

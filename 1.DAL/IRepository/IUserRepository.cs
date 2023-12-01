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
        bool AddUser(User user);
        bool DeletedUser(User user);
        bool UpdateUser(User user);
        ValueReturn GetUser (string username, string password);
        ICollection<User> GetAllUsers();
    }
}

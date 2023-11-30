using _1.DAL.Data;
using _1.DAL.IRepository;
using _1.DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.Repository
{
    public class UserRepository : IUserRepository
    {
        public readonly DataContext _dataContext;

        public UserRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public bool AddUser(User user)
        {
            _dataContext.User.Add(user);
            if (_dataContext.SaveChanges() > 0)
            {
                return true;
            }
            return false;
        }

        public bool DeletedUser(User user)
        {
            throw new NotImplementedException();
        }

        public ICollection<User> GetAllUsers()
        {
            throw new NotImplementedException();
        }

        public bool UpdateUser(User user)
        {
            throw new NotImplementedException();
        }
    }
}

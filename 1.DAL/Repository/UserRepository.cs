using _1.DAL.Data;
using _1.DAL.IRepository;
using _1.DAL.Model;
using Sharing.ReturnModel;

namespace _1.DAL.Repository
{
    public class UserRepository : IUserRepository
    {
        public readonly DataContext _dataContext;

        public UserRepository()
        {
            _dataContext = new DataContext();
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

        public ValueReturn GetUser(string username, string password)
        {
            try
            {
                var user = _dataContext.User.FirstOrDefault(x => x.Username == username && x.Password==password);
                if(user == null)
                {
                    return new ValueReturn { Status= false, Message = "Đăng nhập thất bại" };

                }
                else
                {
                    return new ValueReturn { Status = true, Value = user};
                }
            }
            catch
            {
                return new ValueReturn { Status = false, Message="Lỗi do server" };
            }
        }
    }
}

using _1.DAL.Model;
using _1.DAL.IRepository;
using _2.BUS.IService;
using _1.DAL.Repository;
using Sharing.ReturnModel;

namespace _2.BUS.Service
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

      
        public UserService()
        {
            _userRepository = new UserRepository();
        }

        public bool AddUser(User user)
        {
            return _userRepository.AddUser(user);
        }
        public ValueReturn Validate(string userName, string password)
        {
            if(userName.Trim() != "" && password.Trim() != "") { 
                var result =_userRepository.GetUser(userName, password);
                return result;
                
            }
            else
                return new ValueReturn
                {
                    Status = false,
                    Message = "Không được để trống user name và password",
                };
        }
    }
}

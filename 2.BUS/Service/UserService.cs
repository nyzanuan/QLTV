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

        public async Task<ValueReturn> AddUser(User user)
        {
            return await _userRepository.AddUser(user);
        }

        public bool DeleteUser(int maTacGia)
        {
            return _userRepository.DeletedUser(maTacGia);
        }

        public ValueReturn GetAllUser(int pageNow, int pageSize, string? search, int isAdmin)
        {
            return _userRepository.GetAllUsers(pageNow,  pageSize,  search,  isAdmin);
        }

        public async Task<ValueReturn> UpdateUser(User user)
        {
            string message = string.Empty;
            if(Convert.ToInt16(user.Role) == -1)
            {
                message += " .Vui lòng chọn Vai trò";
            }
            if (Convert.ToInt16(user.Gender) == -1)
            {
                message += " .Vui lòng chọn giới tính";
            }
            if (message !="")
            {
                return new ValueReturn { Message = message , Status =false};
            }
            return await _userRepository.UpdateUser(user);
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

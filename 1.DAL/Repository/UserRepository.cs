using _1.DAL.Data;
using _1.DAL.IRepository;
using _1.DAL.Model;
using Microsoft.EntityFrameworkCore;
using Sharing.Model;
using Sharing.ReturnModel;
using System.Linq;

namespace _1.DAL.Repository
{
    public class UserRepository : IUserRepository
    {
        public readonly DataContext _dataContext;

        public UserRepository()
        {
            _dataContext = new DataContext();
        }

        public async Task<ValueReturn> AddUser(User user)
        {
            try
            {
                _dataContext.ChangeTracker.Entries().Where(e => e.State == EntityState.Modified || e.State == EntityState.Added).ToList().ForEach(e => e.State = EntityState.Detached);

                _dataContext.User.Add(user);
          
                if (await _dataContext.SaveChangesAsync() > 0)
                {
                    return new ValueReturn {Status=true, Message="Thêm thành công" };
                }
                 return new ValueReturn { Status = false, Message = "Thêm thất bại" };
            }
            catch (DbUpdateException ex)
            {
                return new ValueReturn
                {
                    Status = false,
                    Message = ex.InnerException.Message,

                };
            }
          
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
                    return new ValueReturn { Status = true, Value  = new DataReturn
                    {
                        TotalElemnent = 1,
                        ListElemnent = user,
                    } 
                    };
                }
            }
            catch
            {
                return new ValueReturn { Status = false, Message="Lỗi do server" };
            }
        }

        public ValueReturn GetAllUsers(int pageNow, int pageSize, string? search, int isAdmin)
        {
            try
            {
                var query = _dataContext.User.AsQueryable();
                
                if (!string.IsNullOrEmpty(search))
                {
                    string searchLower = search.ToLower();
                    query = query.Where(p=>p.FullName.ToLower().Contains(searchLower) || p.UserId.ToString() ==search || p.Username.ToLower().Contains(searchLower));
                }
                if(isAdmin != -1)
                {
                    if (isAdmin == 0)
                    {
                        query = query.Where(p => p.Role ==UserRole.User);
                    }
                    if (isAdmin == 1)
                    {
                        query = query.Where(p => p.Role == UserRole.Admin);
                    }
                }
                var test = _dataContext.User.ToList();
                var data = query.Skip((pageNow - 1) * pageSize).Take(pageSize).ToList();
                return new ValueReturn { Status = true, Value = new DataReturn { ListElemnent = data, TotalElemnent= query.Count() } };
            }
            catch
            {
                return new ValueReturn { Status = false, Value = new DataReturn { TotalElemnent = 0, ListElemnent = new List<User>() } };
            }
        }

        public bool DeletedUser(int  userId)
        {
            try
            {
                var user = _dataContext.User.FirstOrDefault(p=>p.UserId==userId);
                if (user != null)
                {
                    _dataContext.User.Remove(user);
                    return _dataContext.SaveChanges()>0?true: false;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
        }

        public async Task<ValueReturn> UpdateUser(User user)
        {
            try
            {
                var userData = await _dataContext.User.FirstOrDefaultAsync(p => user.UserId == p.UserId);
                if (userData == null)
                {
                    return new ValueReturn
                    {
                        Status = false,
                        Message = "User không tồn tại để chỉnh sửa"
                    };
                }
                else
                {
                    userData.Username = user.Username;
                    userData.FullName = user.FullName;
                    userData.Password = user.Password;
                    userData.Email = user.Email;
                    userData.Phone = user.Phone;
                    userData.Image = user.Image;
                    userData.Role = user.Role;
                    userData.Gender = user.Gender;
                    _dataContext.User.Update(userData);
                    bool save = await _dataContext.SaveChangesAsync() > 0;
                    if (save)
                    {
                        return new ValueReturn {Status=true, Message = "Cập nhật thành công" };
                    }
                    else
                    {
                        return new ValueReturn
                        {
                            Message = "Lưu thất bại",
                            Status = false,
                        };
                    }

                }
            }
            catch (Exception ex)
            {
                return new ValueReturn
                {
                    Message = ex.InnerException.Message,
                    Status = false,
                };
            }
        }
    }
}

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
        bool AddUser(User user);
        ValueReturn Validate(string userName, string password);

    }
}

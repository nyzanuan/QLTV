using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1.DAL.Model;
using Sharing.ReturnModel;

namespace _1.DAL.IRepository
{
    public interface ICustomerRepository
    {
        bool AddCustomer(Customer customer);
        bool DeleteCustomer(int id);
        bool UpdateCustomer(Customer customer);
        Customer GetCustomer(int id);
        ValueReturn GetAllCustomer(int pageIndex, int pageSize, string? search);
    }
}

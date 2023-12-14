using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1.DAL.Model;
using Sharing.ReturnModel;

namespace _2.BUS.IService
{
    public interface ICustomerService
    {
        Task<ValueReturn> AddCustomer(Customer customer);
        bool DeleteCustomer(int id);
        Task<ValueReturn> UpdateCustomer(Customer customer);
        Customer GetCustomer(int id);
        ValueReturn GetAllCustomer(int pageIndex, int pageSize, string? search);
    }
}

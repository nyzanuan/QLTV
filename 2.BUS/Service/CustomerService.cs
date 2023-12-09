using _1.DAL.IRepository;
using _1.DAL.Model;
using _1.DAL.Repository;
using _2.BUS.IService;
using Sharing.ReturnModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.Service
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepository _customerRepository;
        public CustomerService()
        {
            _customerRepository = new CustomerRepository();
        }

        public bool AddCustomer(Customer customer)
        {
            return _customerRepository.AddCustomer(customer);
        }

        public bool DeleteCustomer(int id)
        {
            return _customerRepository.DeleteCustomer(id);
        }

        public ValueReturn GetAllCustomer(int pageIndex, int pageSize, string? search)
        {
            try
            {
                ValueReturn result = _customerRepository.GetAllCustomer(pageIndex, pageSize, search);
                return result; 
            }
            catch (Exception ex)
            {
                return new ValueReturn()
                {
                    Message = ex.Message,
                    Status = false,
                    Value = new DataReturn
                    {
                        TotalElemnent = 0,
                        ListElemnent = Array.Empty<Customer>(),
                    }

                };
            }
        }

        public Customer GetCustomer(int id)
        {
            return _customerRepository.GetCustomer(id);
        }

        public bool UpdateCustomer(Customer customer)
        {
            return _customerRepository.UpdateCustomer(customer);
        }
    }
}

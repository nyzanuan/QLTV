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
        private ValueReturn check(Customer customer)
        {
            if (customer.Phone.Length!=10||!customer.Phone.StartsWith("0"))
            {
                return new ValueReturn { Message ="Số điện thoại gồm 10 số và bắt đầu bắt số 0.", Status=false};
            }
            if (!customer.Email.EndsWith("@gmail.com"))
            {
                return new ValueReturn { Message = "Email phải là dạng @gmail.com.", Status = false };
            }
            if (customer.Gender.ToString()=="")
            {
                return new ValueReturn { Message = "Chọn giới tính.", Status = false };
            }
            return new ValueReturn();
        }
        public async Task<ValueReturn> AddCustomer(Customer customer)
        {
            return !string.IsNullOrEmpty(check(customer).Message) ? check(customer) : await _customerRepository.AddCustomer(customer);
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

        public async Task<ValueReturn> UpdateCustomer(Customer customer)
        {
            return !string.IsNullOrEmpty(check(customer).Message) ? check(customer) : await _customerRepository.UpdateCustomer(customer);
        }
    }
}


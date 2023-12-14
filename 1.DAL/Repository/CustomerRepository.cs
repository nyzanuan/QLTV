using _1.DAL.Data;
using _1.DAL.IRepository;
using _1.DAL.Model;
using Microsoft.EntityFrameworkCore;
using Sharing.ReturnModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.Repository
{
    public class CustomerRepository : ICustomerRepository
    {
        public readonly DataContext _dataContext;
        public CustomerRepository()
        {
            _dataContext = new DataContext();
        }
        public async Task<ValueReturn> AddCustomer(Customer customer)
        {
            try
            {
                _dataContext.Customer.Add(customer);
                if (await _dataContext.SaveChangesAsync() > 0)
                {
                    return new ValueReturn { Status = true, Message = "Thêm thành công" };
                }
                return new ValueReturn { Status = false, Message = "Thêm thất bại" };
            }
            catch(DbUpdateException e)
            {
                return new ValueReturn
                {
                    Status = false,
                    Message = e.InnerException.Message,

                };
            }
        }
        public bool SaveData()
        {
            var result = _dataContext.SaveChanges() > 0;
            return result;
        }
        public bool DeleteCustomer(int id)
        {
            try
            {
                var customer = _dataContext.Customer.FirstOrDefault(p => p.CustomerId == id);
                _dataContext.Customer.Remove(customer);
                return SaveData();
            }
            catch
            {
                return false;
            }
        }

        public ValueReturn GetAllCustomer(int pageIndex, int pageSize, string? search)
        {
            try
            {
                var query = _dataContext.Customer.AsQueryable();
                if (!string.IsNullOrEmpty(search))
                {
                    string searchWithoutDiacritics = search.ToLower();
                    query = query.Where(p =>
                        p.Name.ToLower().Contains(searchWithoutDiacritics)
                    );
                }
                return new ValueReturn()
                {
                    Status = true,
                    Value = new DataReturn()
                    {
                        ListElemnent = query.Skip((pageIndex - 1) * pageSize).Take(pageSize).ToList(),
                        TotalElemnent = query.Count()
                    }

                };
            }
            catch (Exception ex)
            {
                return new ValueReturn()
                {
                    Message = ex.Message,
                    Status = false,
                    Value = new DataReturn()
                    {
                        ListElemnent = Array.Empty<Customer>(),
                        TotalElemnent = 0

                    }
                };
            }
        }

        public Customer GetCustomer(int id)
        {
            Customer cusD = _dataContext.Customer.FirstOrDefault(p => p.CustomerId == id);
            if (cusD != null)
                return cusD;
            else 
                return new Customer();
            
        }

        public async Task<ValueReturn> UpdateCustomer(Customer customer)
        {
            try
            {
                var customerData = _dataContext.Customer.FirstOrDefault(p => p.CustomerId == customer.CustomerId);
                if (customerData != null)
                {
                    customerData.Name = customer.Name;
                    customerData.Email = customer.Email;
                    customerData.Phone = customer.Phone;
                    customerData.Gender = customer.Gender;
                    customerData.Image = customer.Image;
                    _dataContext.Customer.Update(customerData);
                    bool save = await _dataContext.SaveChangesAsync() > 0;
                    if (save)
                    {
                        return new ValueReturn { Status = true, Message = "Cập nhật thành công" };
                    }
                    else
                    {
                        return new ValueReturn
                        {
                            Message = "Cập nhập thất bại",
                            Status = false,
                        };
                    }
                }
                else
                {
                    return new ValueReturn
                    {
                        Status = false,
                        Message = "Đọc giả không tồn tại để chỉnh sửa"
                    };
                }
            }

            catch(Exception e) {
                return new ValueReturn
                {
                    Message = e.InnerException.Message,
                    Status = false,
                };
            }

        }
    }
    
}

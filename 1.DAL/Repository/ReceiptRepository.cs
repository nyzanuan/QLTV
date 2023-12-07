using _1.DAL.Data;
using _1.DAL.IRepository;
using Sharing.Model;
using Sharing.ReturnModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.Repository
{
    public class ReceiptRepository : IReceiptRepository
    {
        private readonly DataContext _dataContext;
        public ReceiptRepository()
        {
            _dataContext = new DataContext();
        }
        public ValueReturn GetAllReceipt(int pageIndex, int pageSize, string? search, LoanReceiptStatus? loanReceiptStatus)
        {
            try
            {
                var query = _dataContext.LoanReceipt.AsQueryable();
                if (!string.IsNullOrEmpty(search))
                {
                    query = query.Where(p => p.CustomerId.ToString() == search || p.BookId.ToString() == search);
                }
                if(loanReceiptStatus != null)
                {
                    
                }
                return new ValueReturn { };
            }
            catch (Exception ex) 
            {
                return new ValueReturn
                {
                    Status = false,
                    Message= string.IsNullOrEmpty(ex.InnerException.Message)?ex.Message:ex.InnerException.Message,
                };
            }
            
        }
    }
}

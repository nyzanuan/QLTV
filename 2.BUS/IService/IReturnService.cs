using _1.DAL.Model;
using Sharing.Model;
using Sharing.ReturnModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.IService
{
    public interface IReturnService
    {
        Task<bool> returnBook(LoanReceipt newLoan);
        Task<bool> renewBook(LoanReceipt newLoan);        
        ValueReturn GetAllReceipt(int pageIndex, int pageSize, string? search, LoanReceiptStatus? loanReceiptStatus);
    }
}

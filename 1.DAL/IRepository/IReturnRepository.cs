using _1.DAL.Model;
using Sharing.Model;
using Sharing.ReturnModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.IRepository
{
    public interface IReturnRepository
    {
        Task<bool> returnBook(LoanReceipt newLoan);
        Task<bool> renewBook(LoanReceipt newLoan);
        Task<bool> UpdateBookCopies(int bookId, int quantity);
        ValueReturn GetAllReceipt(int pageIndex, int pageSize, string? search, LoanReceiptStatus? loanReceiptStatus);
    }
}

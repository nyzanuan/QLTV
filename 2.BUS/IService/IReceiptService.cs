using _1.DAL.Model;
using Sharing.Model;
using Sharing.ReturnModel;

namespace _2.BUS.IService
{
    public interface IReceiptService
    {
        Task<ValueReturn> AddLoanReceipt(LoanReceipt newLoan);
        bool DeleteLoanReceipt(int loanId);
        List<Book> getAllBook(string? search);
        List<Customer> getAllCustomer(string? search);
        ValueReturn GetAllReceipt(int pageIndex, int pageSize, string? search, LoanReceiptStatus? loanReceiptStatus);
        Task<ValueReturn> UpdateLoanReceipt(LoanReceipt newLoan);
    }
}

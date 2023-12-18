using _1.DAL.Model;
using Sharing.Model;
using Sharing.ReturnModel;

namespace _1.DAL.IRepository
{
    public interface IReceiptRepository
    {
        Task<ValueReturn> AddLoanReceipt(LoanReceipt newLoan);
        bool DeleteLoanReceipt(int loanId);
        List<Book> getAllBook(string? search);
        List<Customer> getAllCustomer(string? search);
        ValueReturn GetAllReceipt(int pageIndex, int pageSize, string? search, LoanReceiptStatus? loanReceiptStatus);
        Task<ValueReturn> UpdateLoanReceipt(LoanReceipt newLoan);
        IEnumerable<BookData> GetLoanSummary(DateTime startDate, DateTime endDate);
        int CountBook();
        int CountCustomer();
        int CountUser();
        IEnumerable<KeyValuePair<string, string>> getTopBook();
    }
}

using _1.DAL.IRepository;
using _1.DAL.Model;
using _1.DAL.Repository;
using _2.BUS.IService;
using Sharing.Model;
using Sharing.ReturnModel;

namespace _2.BUS.Service
{
    public class ReceiptService : IReceiptService
    {
        private readonly IReceiptRepository _receiptRepository;
        public ReceiptService()
        {
            _receiptRepository = new ReceiptRepository();
        }

        public async Task<ValueReturn> AddLoanReceipt(LoanReceipt newLoan)
        {
            if (newLoan.BookId == -1)
            {
                return new ValueReturn
                {
                    Status = false,
                    Message = "Hãy chọn Book cần mượn"
                };
            }
            if (newLoan.CustomerId == -1)
            {
                return new ValueReturn
                {
                    Status = false,
                    Message = "Hãy chọn Customer mượn sách"
                };
            }
            return await _receiptRepository.AddLoanReceipt(newLoan);
        }

        public bool DeleteLoanReceipt(int loanId)
        {
            return _receiptRepository.DeleteLoanReceipt(loanId);
        }

        public List<Book> getAllBook(string? search)
        {
            return _receiptRepository.getAllBook(search);
        }

        public List<Customer> getAllCustomer(string? search)
        {
            return _receiptRepository.getAllCustomer(search);
        }

        public ValueReturn GetAllReceipt(int pageIndex, int pageSize, string? search, LoanReceiptStatus? loanReceiptStatus)
        {
            return _receiptRepository.GetAllReceipt(pageIndex, pageSize, search, loanReceiptStatus);
        }

        public async Task<ValueReturn> UpdateLoanReceipt(LoanReceipt newLoan)
        {
            if (newLoan.BookId == -1)
            {
                return new ValueReturn
                {
                    Status = false,
                    Message = "Hãy chọn Book cần mượn"
                };
            }
            if (newLoan.CustomerId == -1)
            {
                return new ValueReturn
                {
                    Status = false,
                    Message = "Hãy chọn Customer mượn sách"
                };
            }
            return await _receiptRepository.UpdateLoanReceipt(newLoan);
        }
    }
}

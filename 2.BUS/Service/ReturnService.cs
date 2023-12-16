using _1.DAL.IRepository;
using _1.DAL.Model;
using _1.DAL.Repository;
using _2.BUS.IService;
using Sharing.Model;
using Sharing.ReturnModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.Service
{
    public class ReturnService : IReturnService
    {
        private readonly IReturnRepository _returnRepository;
        public ReturnService()
        {
            _returnRepository = new ReturnRepository();
        }

        public ValueReturn GetAllReceipt(int pageIndex, int pageSize, string? search, LoanReceiptStatus? loanReceiptStatus)
        {
            return _returnRepository.GetAllReceipt(pageIndex, pageSize, search, loanReceiptStatus);
        }

        public Task<bool> renewBook(LoanReceipt newLoan)
        {
            return _returnRepository.renewBook(newLoan);
        }

        public Task<bool> returnBook(LoanReceipt newLoan)
        {
            return (_returnRepository.returnBook(newLoan));
        }

    }
}

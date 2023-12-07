using _1.DAL.IRepository;
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
    public class ReceiptService : IReceiptService
    {
        private readonly IReceiptRepository _receiptRepository;
        public ReceiptService()
        {
            _receiptRepository = new ReceiptRepository();
        }
        

        public ValueReturn GetAllReceipt(int pageIndex, int pageSize, string? search, LoanReceiptStatus? loanReceiptStatus)
        {
            return _receiptRepository.GetAllReceipt(pageIndex, pageSize, search, loanReceiptStatus);
        }
    }
}

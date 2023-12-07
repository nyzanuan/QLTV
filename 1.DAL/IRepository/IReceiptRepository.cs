using Sharing.Model;
using Sharing.ReturnModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.IRepository
{
    public interface IReceiptRepository
    {
        ValueReturn GetAllReceipt(int pageIndex, int pageSize, string? search, LoanReceiptStatus? loanReceiptStatus);
    }
}

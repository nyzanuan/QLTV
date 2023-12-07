using Sharing.Model;
using Sharing.ReturnModel;

namespace _2.BUS.IService
{
    public interface  IReceiptService
    {
        ValueReturn GetAllReceipt(int pageIndex, int pageSize, string? search, LoanReceiptStatus? loanReceiptStatus );
    }
}

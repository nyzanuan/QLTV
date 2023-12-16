using Sharing.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.IRepository
{
    public interface IReportRepository
    {
        List<ReceiptInfo> GetReceipt(DateTime startDate, DateTime endDate);

        List<MaxBookInfo> GetBook(DateTime startDate, DateTime endDate);

        List<QuantityInfo> GetQuantityBook();
    }
}

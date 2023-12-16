using Sharing.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.IService
{
    public interface IReportService
    {
        List<ReceiptInfo> GetReceipt(DateTime startDate, DateTime endDate);

        List<MaxBookInfo> GetBook(DateTime startDate, DateTime endDate);

        List<QuantityInfo> GetQuantityBook();
    }
}

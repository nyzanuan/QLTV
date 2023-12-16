using _1.DAL.IRepository;
using _1.DAL.Repository;
using _2.BUS.IService;
using Sharing.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.Service
{
    public class ReportService : IReportService
    {   
        private readonly IReportRepository _reportRepository;
        
        public ReportService() 
        {
            _reportRepository = new ReportRepository();
        }
        public List<MaxBookInfo> GetBook(DateTime startDate, DateTime endDate)
        {
            return _reportRepository.GetBook(startDate, endDate);
        }

        public List<QuantityInfo> GetQuantityBook()
        {
            return _reportRepository.GetQuantityBook();
        }

        public List<ReceiptInfo> GetReceipt(DateTime startDate, DateTime endDate)
        {
            return _reportRepository.GetReceipt(startDate,endDate);
        }
    }
}

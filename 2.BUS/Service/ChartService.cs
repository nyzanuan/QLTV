using _1.DAL.IRepository;
using _1.DAL.Repository;
using _2.BUS.IService;
using Sharing.Model;

namespace _2.BUS.Service
{
    public class ChartService : IChartService
    {
        private readonly IReceiptRepository _receiptRepository;
        public ChartService()
        {
            _receiptRepository = new ReceiptRepository();
        }

        public int CountBook()
        {
            return _receiptRepository.CountBook();
        }

        public int CountCustomer()
        {
            return _receiptRepository.CountCustomer();
        }



        public int CountUser()
        {
            return _receiptRepository.CountUser();
        }

        public IEnumerable<BookData> getListBookWithDay(DateTime startDate, DateTime endDate)
        {
            return _receiptRepository.GetLoanSummary(startDate, endDate);
        }

        public IEnumerable<KeyValuePair<string, string>> getTopBook()
        {
            return _receiptRepository.getTopBook();
        }

        public void LoadDataChart()
        {
            throw new NotImplementedException();
        }
    }
}

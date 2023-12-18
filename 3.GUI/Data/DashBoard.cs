using _2.BUS.IService;
using _2.BUS.Service;

namespace Sharing.Model
{
    public class DashBoard
    {

        private readonly IChartService _chartService;
        private DateTime startDate;
        private DateTime endDate;
        private int numberDays;
        public int TongSachMuon { get; set; }
        public int TongSachTra { get; set; }
        public int TongSachChuatra { get; set; }
        public int NumCustomers { get; private set; }
        public int NumBook { get; private set; }
        public int NumUser { get; private set; }
        public List<KeyValuePair<string, string>> TopBook { get; private set; }
        public List<KeyValuePair<string, string>> GrossRevenueList { get; private set; }

        public IEnumerable<BookData> ListBookWithDay { get; private set; }
        public DashBoard()
        {
            _chartService = new ChartService();
        }

        public void LoadData(DateTime startDate, DateTime endDate)
        {
            endDate = new DateTime(endDate.Year, endDate.Month, endDate.Day,
                 endDate.Hour, endDate.Minute, 59);
            if (startDate != this.startDate || endDate != this.endDate)
            {
                this.startDate = startDate;
                this.endDate = endDate;
                this.numberDays = (endDate - startDate).Days;
                this.ListBookWithDay = _chartService.getListBookWithDay(startDate, endDate);
                this.TopBook = new List<KeyValuePair<string, string>>(_chartService.getTopBook());

            }



        }
        public void LoadDataNonStatic()
        {
            this.NumCustomers = _chartService.CountCustomer();
            this.NumUser = _chartService.CountUser();
            this.NumBook = _chartService.CountBook();



        }
    }
}

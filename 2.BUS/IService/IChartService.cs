using Sharing.Model;

namespace _2.BUS.IService
{
    public interface IChartService
    {
        IEnumerable<BookData> getListBookWithDay(DateTime startDate, DateTime endDate);
        void LoadDataChart();
        int CountUser();
        int CountCustomer();
        int CountBook();
        IEnumerable<KeyValuePair<string, string>> getTopBook();

    }
}

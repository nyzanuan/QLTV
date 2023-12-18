using _1.DAL.Data;
using _1.DAL.IRepository;
using Sharing.Model;

namespace _1.DAL.Repository
{
    public class ReportRepository : IReportRepository
    {
        private readonly DataContext _dataContext;
        public ReportRepository()
        {
            _dataContext = new DataContext();
        }
        public List<MaxBookInfo> GetBook(DateTime startDate, DateTime endDate)
        {
            try
            {


                var result = _dataContext.Book
     .Join(_dataContext.LoanReceipt, b => b.BookId, l => l.BookId, (b, l) => new
     {
         BookName = b.Name,
         Category = b.Category.Name,
         Publisher = b.Publisher.Name,
         Language = b.Language.Name,
         BorrowDate = l.BorrowDate,
         ReturnDate = l.ReturnDate,
         BorrowedCopies = b.BorrowedCopies
     })
     .Where(c => c.BorrowDate >= startDate && c.BorrowDate <= endDate)
     .GroupBy(b => b.BookName)
     .Select(group => new MaxBookInfo
     {
         BookName = group.Key,
         Category = group.First().Category,
         Publisher = group.First().Publisher,
         Language = group.First().Language,
         BorrowDate = group.First().BorrowDate,
         ReturnDate = group.First().ReturnDate,
         sumBorrowBook = group.Sum(item => item.BorrowedCopies)
     })
     .OrderByDescending(b => b.sumBorrowBook)
     .ToList();
                return result;
            }
            catch (Exception ex)
            {

                return new List<MaxBookInfo>();
            }
        }

        public List<QuantityInfo> GetQuantityBook()
        {
            try
            {
                var result = _dataContext.Book.Select(countbook => new QuantityInfo
                {
                    BookName = countbook.Name,
                    Category = countbook.Category.Name,
                    Publisher = countbook.Publisher.Name,
                    Language = countbook.Language.Name,
                    AvailableCopies = countbook.AvailableCopies,
                }).ToList();
                return result;
            }
            catch (Exception ex)
            {

                return new List<QuantityInfo>();
            }
        }

        public List<ReceiptInfo> GetReceipt(DateTime startDate, DateTime endDate)
        {
            try
            {

                var result = _dataContext.LoanReceipt.Where(c => c.BorrowDate >= startDate && c.BorrowDate <= endDate).Select(a => new ReceiptInfo
                {
                    NameUser = a.Customer.Name,
                    EmailUser = a.Customer.Email,
                    BookName = a.Book.Name,
                    StatusBook = a.Book.Status,
                    DayBorrow = a.BorrowDate,
                    DayReturn = a.ReturnDate,
                }).OrderBy(b => b.DayBorrow).ToList();
                return result;

            }
            catch (Exception ex)
            {
                return new List<ReceiptInfo>();
            }
        }
    }
}

using _1.DAL.Data;
using _1.DAL.IRepository;
using _1.DAL.Model;
using Microsoft.EntityFrameworkCore;
using Sharing.Model;
using Sharing.ReturnModel;

namespace _1.DAL.Repository
{
    public class ReturnRepository : IReturnRepository
    {
        private readonly DataContext _dataContext;
        public ReturnRepository()
        {
            _dataContext = new DataContext();
        }
        public async Task<bool> UpdateBookCopies(int bookId, int quantity)
        {
            try
            {
                var book = await _dataContext.Book.FindAsync(bookId);
                if (book != null)
                {
                    book.AvailableCopies += quantity;
                    book.BorrowedCopies -= quantity;
                    _dataContext.Entry(book).State = EntityState.Modified;
                    await _dataContext.SaveChangesAsync();
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public async Task<bool> renewBook(LoanReceipt newLoan)
        {
            try
            {
                _dataContext.ChangeTracker.Entries().Where(e => e.State == EntityState.Modified || e.State == EntityState.Added).ToList().ForEach(e => e.State = EntityState.Detached);

                LoanStatus loanReceipt = await _dataContext.LoanReceiptStatuse.FirstOrDefaultAsync(p => p.LoanReceiptId == newLoan.LoanReceiptId);
                if (loanReceipt == null) { return false; }
                else
                {
                    loanReceipt.Status = LoanReceiptStatus.Extend;
                    _dataContext.LoanReceipt.Update(newLoan);
                    _dataContext.LoanReceiptStatuse.Update(loanReceipt);
                    if (await _dataContext.SaveChangesAsync() > 0)
                    {
                        return true;
                    }
                    return false;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public async Task<bool> returnBook(LoanReceipt newLoan)
        {
            try
            {
                _dataContext.ChangeTracker.Entries().Where(e => e.State == EntityState.Modified || e.State == EntityState.Added).ToList().ForEach(e => e.State = EntityState.Detached);

                LoanStatus loanReceipt = await _dataContext.LoanReceiptStatuse.FirstOrDefaultAsync(p => p.LoanReceiptId == newLoan.LoanReceiptId);
                if (loanReceipt == null) { return false; }
                else
                {
                    loanReceipt.Status = LoanReceiptStatus.Returned;
                    _dataContext.LoanReceipt.Update(newLoan);
                    _dataContext.LoanReceiptStatuse.Update(loanReceipt);
                    if (await _dataContext.SaveChangesAsync() > 0)
                    {
                        return await UpdateBookCopies(newLoan.BookId, 1);
                    }
                    return false;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public ValueReturn GetAllReceipt(int pageIndex, int pageSize, string? search, LoanReceiptStatus? loanReceiptStatus)
        {
            try
            {
                var query = _dataContext.LoanReceipt
                    .Include(p => p.Book)
                    .Join(_dataContext.LoanReceiptStatuse, receipt => receipt.LoanReceiptId, status => status.LoanReceiptId,
                        (receipt, status) => new { Receipt = receipt, Status = status }
                     ).AsQueryable();

                if (!string.IsNullOrEmpty(search))
                {
                    query = query.Where(p => p.Receipt.CustomerId.ToString() == search || p.Receipt.BookId.ToString() == search||p.Receipt.LoanReceiptId.ToString()==search);
                }
                if (loanReceiptStatus != null)
                {
                    query = query.Where(p => (p.Status.Status == LoanReceiptStatus.Borrowed || p.Status.Status == LoanReceiptStatus.Extend));
                }
                var data = query.Skip((pageIndex - 1) * pageSize).Take(pageSize).Select(p => new LoanReceiptReturn
                {
                    LoanId = p.Receipt.LoanReceiptId,
                    CustomerName = p.Receipt.Customer.Name,
                    BookName = p.Receipt.Book.Name,
                    Note = p.Receipt.Note,
                    ReceiveDate = p.Receipt.BorrowDate,
                    ReturnDate = p.Receipt.ReturnDate,
                    Status = p.Status.Status,
                    ImageCustomer = p.Receipt.Customer.Image,
                    ImageBook = p.Receipt.Book.Image,
                    CustomerId = p.Receipt.CustomerId,
                    BookId = p.Receipt.BookId,


                }).ToList();
                return new ValueReturn { Status = true, Value = new DataReturn { ListElemnent = data, TotalElemnent = query.Count() } };
            }
            catch (Exception ex)
            {
                return new ValueReturn
                {
                    Status = false,
                    Message = string.IsNullOrEmpty(ex.InnerException.Message) ? ex.Message : ex.InnerException.Message,
                    Value = new DataReturn { TotalElemnent = 0, ListElemnent = Array.Empty<LoanReceipt>() }
                };
            }
        }


    }
}

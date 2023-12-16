using _1.DAL.Data;
using _1.DAL.IRepository;
using _1.DAL.Model;
using Microsoft.EntityFrameworkCore;
using Sharing.Model;
using Sharing.ReturnModel;

namespace _1.DAL.Repository
{
    public class ReceiptRepository : IReceiptRepository
    {
        private readonly DataContext _dataContext;
        public ReceiptRepository()
        {
            _dataContext = new DataContext();
        }
        public async Task<bool> UpdateBookBorrowed(int bookId, int quantity)
        {
            try
            {
                var book = await _dataContext.Book.FindAsync( bookId );
                if (book != null)
                {
                    if (book.AvailableCopies >= quantity)
                    {
                        book.AvailableCopies -= quantity;
                        book.BorrowedCopies += quantity;
                        _dataContext.Entry(book).State = EntityState.Modified;
                        await _dataContext.SaveChangesAsync();
                        return true;    
                    }
                    else { return false; }
                }
                return false;
            }catch (Exception ex)
            {
                return false;
            }
        }

        public async Task<ValueReturn> AddLoanReceipt(LoanReceipt newLoan)
        {
            try
            {
                _dataContext.ChangeTracker.Entries().Where(e => e.State == EntityState.Modified || e.State == EntityState.Added).ToList().ForEach(e => e.State = EntityState.Detached);

                newLoan.StatusList = new List<LoanStatus>();
                newLoan.StatusList.Add(new LoanStatus { CreateAt = DateTime.Now, Status = LoanReceiptStatus.Borrowed });
                _dataContext.LoanReceipt.Add(newLoan);

                if (await _dataContext.SaveChangesAsync() > 0)
                {
                    await UpdateBookBorrowed(newLoan.BookId,1);
                    return new ValueReturn { Status = true, Message = "Thêm thành công" };
                }
                return new ValueReturn { Status = false, Message = "Thêm thất bại" };



            }
            catch (Exception ex)
            {
                return new ValueReturn
                {
                    Status = false,
                    Message = string.IsNullOrEmpty(ex.InnerException.Message) ? ex.Message : ex.InnerException.Message,
                };
            }
        }

        public bool DeleteLoanReceipt(int loanId)
        {
            try
            {
                LoanReceipt loanReceipt = _dataContext.LoanReceipt.FirstOrDefault(p => p.LoanReceiptId == loanId);
                if (loanReceipt == null) { return false; }
                _dataContext.LoanReceipt.Remove(loanReceipt);
                if (_dataContext.SaveChanges() > 0)
                {
                    return true;
                }
                return false;
            }
            catch
            {
                return false;
            }
        }

        public List<Book> getAllBook(string? search)
        {
            try
            {
                var query = _dataContext.Book.AsQueryable();
                if (!string.IsNullOrEmpty(search))
                {
                    string searchLower = search.ToLower();
                    query = query.Where(x => x.Name.ToLower().Contains(searchLower) || x.Title.Contains(searchLower) || x.BookId.ToString() == search);
                }
                return query.ToList();
            }
            catch
            {
                return new List<Book>();
            }
        }

        public List<Customer> getAllCustomer(string? search)
        {
            try
            {
                var query = _dataContext.Customer.AsQueryable();
                if (!string.IsNullOrEmpty(search))
                {
                    string searchLower = search.ToLower();
                    query = query.Where(x => x.Name.ToLower().Contains(searchLower) || x.Email.Contains(searchLower) || x.CustomerId.ToString() == search);
                }
                return query.ToList();
            }
            catch
            {
                return new List<Customer>();
            }
        }

        public ValueReturn GetAllReceipt(int pageIndex, int pageSize, string? search, LoanReceiptStatus? loanReceiptStatus)
        {
            try
            {
                var query = _dataContext.LoanReceipt.Include(p => p.Book).AsQueryable();

                if (!string.IsNullOrEmpty(search))
                {
                    query = query.Where(p => p.CustomerId.ToString() == search || p.BookId.ToString() == search);
                }
                if (loanReceiptStatus != null)
                {
                    query = query.Where(p => p.StatusList.OrderByDescending(a => a.CreateAt).Select(a => a.Status).FirstOrDefault() == loanReceiptStatus);
                }
                var data = query.Skip((pageIndex - 1) * pageSize).Take(pageSize).Select(p => new LoanReceiptReturn
                {
                    LoanId = p.LoanReceiptId,
                    CustomerName = "CustomerId: " + p.CustomerId + " CustomerName: " + p.Customer.Name,
                    BookName = p.Book.Name,
                    Note = p.Note,
                    ReceiveDate = p.BorrowDate,
                    ReturnDate = p.ReturnDate,
                    Status = p.StatusList.OrderByDescending(c => c.CreateAt).Select(c => c.Status).FirstOrDefault(),
                    ImageCustomer = p.Customer.Image,
                    ImageBook = p.Book.Image,
                    CustomerId = p.CustomerId,
                    BookId = p.BookId,


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

        public async Task<ValueReturn> UpdateLoanReceipt(LoanReceipt newLoan)
        {
            try
            {
                _dataContext.ChangeTracker.Entries().Where(e => e.State == EntityState.Modified || e.State == EntityState.Added).ToList().ForEach(e => e.State = EntityState.Detached);

                LoanReceipt loanReceipt = await _dataContext.LoanReceipt.FirstOrDefaultAsync(p => p.LoanReceiptId == newLoan.LoanReceiptId);

                loanReceipt.CustomerId = newLoan.CustomerId;
                loanReceipt.BookId = newLoan.BookId;
                loanReceipt.ReturnDate = newLoan.ReturnDate;

                _dataContext.LoanReceipt.Update(loanReceipt);

                if (await _dataContext.SaveChangesAsync() > 0)
                {
                    return new ValueReturn { Status = true, Message = "Thêm thành công" };
                }
                return new ValueReturn { Status = false, Message = "Thêm thất bại" };



            }
            catch (Exception ex)
            {
                return new ValueReturn
                {
                    Status = false,
                    Message = string.IsNullOrEmpty(ex.InnerException.Message) ? ex.Message : ex.InnerException.Message,
                };
            }
        }
    }
}

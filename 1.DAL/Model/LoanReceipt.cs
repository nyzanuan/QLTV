using Microsoft.EntityFrameworkCore.Metadata;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.SymbolStore;
using System.Threading.Channels;

namespace _1.DAL.Model
{
    public class LoanReceipt
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int LoanReceiptId { get; set; }
        public int BookId { get; set; }
        public Book Book { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        public DateTime BorrowDate { get; set; }
        public DateTime ReturnDate { get; set; }
        public int BorrowerId { get; set; }
        public User Borrower { get; set; }

        public string? Note { get; set; }


        public ICollection<LoanStatus> StatusList { get; set; }
        

    }
}

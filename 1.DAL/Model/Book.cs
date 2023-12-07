using Sharing.Model;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _1.DAL.Model
{
    public class Book
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int BookId { get; set; }
        public string Name { get; set; }
        public string? Title { get; set; }
        public int AuthorId { get; set; }
        public Author Author { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public int PublisherId { get; set; }
        public Publisher Publisher { get; set; }
        public int TotalCopies { get; set; }
        public int AvailableCopies { get; set; }
        public int BorrowedCopies { get; set; }
        public BookStatus Status { get; set; }
        public LoanAvailability Availability { get; set; }
        public byte[]? Image { get; set; }
        public int? LanguageId { get; set; }

        public Language? Language { get; set; }
        public List<LoanReceipt> LoanReceipts { get; set; }
    }
}

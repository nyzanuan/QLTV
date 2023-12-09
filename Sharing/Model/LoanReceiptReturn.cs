namespace Sharing.Model
{
    public class LoanReceiptReturn
    {
        public int LoanId { get; set; }

        public int BookId { get; set; }

        public int CustomerId { get; set; }
        public string BookName { get; set; }
        public string CustomerName { get; set; }

        public DateTime ReturnDate { get; set; }
        public DateTime ReceiveDate { get; set; }

        public string Note { get; set; }

        public LoanReceiptStatus Status { get; set; }
        public byte[] ImageBook { get; set; }
        public byte[] ImageCustomer { get; set; }

    }
}

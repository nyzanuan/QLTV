using Sharing.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.Model
{
    public class LoanStatus
    {
        public int StatusId { get; set; }
        public LoanReceiptStatus Status { get; set; }

        public DateTime CreateAt { get; set; }
        public int LoanReceiptId { get; set; }
        public LoanReceipt LoanReceipt { get; set; }
    }
}

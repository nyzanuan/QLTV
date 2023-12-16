using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sharing.Model
{
    public class MaxBookInfo
    {
        public string BookName { get; set; }
        public string Category { get; set; }
        public string Publisher { get; set; }
        public string Language { get; set; }    
        public DateTime BorrowDate { get; set; } // Loan date field
        public DateTime ReturnDate { get; set; } // Return date field
        public int sumBorrowBook { get; set; }
    }
}

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
        public int BorrowedCopies { get; set; }
    }
}

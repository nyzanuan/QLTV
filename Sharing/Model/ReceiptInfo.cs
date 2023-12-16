using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sharing.Model
{
    public class ReceiptInfo
    {
        public string NameUser { get; set; }
        public string EmailUser { get; set; }
        public string BookName { get; set; }
        public BookStatus StatusBook { get; set; }       
        public DateTime DayBorrow { get; set; }
        public DateTime DayReturn { get; set; }
    }
}

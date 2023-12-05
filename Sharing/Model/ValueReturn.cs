using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sharing.ReturnModel
{
    public struct DataReturn
    {
        public int TotalElemnent;
        public object ListElemnent;
    }
    public class ValueReturn
    {
        public bool Status { get; set; }
        public string Message { get; set; }
        public DataReturn Value { get; set; }

    }
}

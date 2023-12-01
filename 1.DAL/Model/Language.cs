using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.Model
{
    public class Language
    {
        public int LanguageId { get; set; }
        public string Name { get; set; }

        public ICollection<Book> Book { get; set; }
    }
}

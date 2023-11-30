using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.Model
{
    public class User
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int UserId { get; set; }


        public string Username { get; set; }


        public string Password { get; set; }


        public string FullName { get; set; }


        public string Email { get; set; }


        public bool IsAdmin { get; set; }

        public List<LoanReceipt> LoanReceipts { get; set; }
    }
}

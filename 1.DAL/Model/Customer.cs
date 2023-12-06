using Sharing.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.Model
{
    public class Customer
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int CustomerId { get; set; }
        public string Name { get; set; }
        public byte[]? Image { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public Gender Gender { get; set; }
        public DateTime CreateAt { get; set; }
        public int? UserIdCreate { get; set; }
        public User? UserCreate { get; set; }
        public List<LoanReceipt> LoanReceipts { get; set; }
    }

}

using Sharing.Model;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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

        public string Phone { get; set; }
        public Gender Gender { get; set; }
        public UserRole Role { get; set; }


        public byte[]? Image { get; set; }

        public List<Customer> CustomerCreated { get; set; }

        public List<LoanReceipt> LoanReceipts { get; set; }
    }
}

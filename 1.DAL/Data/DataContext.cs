using _1.DAL.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.Data
{
    public class DataContext: DbContext
    {

        public virtual DbSet<Author> Author { get; set; }
        public virtual DbSet<Book> Book { get; set; }
        public virtual DbSet<Category> Category { get; set; }
        public virtual DbSet<Customer> Customer { get; set; }
        public virtual DbSet<LoanReceipt> LoanReceipt { get; set; }
        public virtual DbSet<Publisher> Publisher { get; set; }
        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<Language> Language { get; set; }
        
        public virtual DbSet<LoanStatus> LoanReceiptStatuse { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Data Source=SQL5105.site4now.net;Initial Catalog=db_aa21b3_sa;User ID=db_aa21b3_sa_admin;Password=Long123@;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Author>().ToTable("Author");
            modelBuilder.Entity<Author>().HasMany(p=>p.Books).WithOne(p=>p.Author).HasForeignKey(p=>p.AuthorId).OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Category>().ToTable("Category");
            modelBuilder.Entity<Category>().HasMany(p => p.Books).WithOne(p => p.Category).HasForeignKey(p => p.CategoryId).OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Category>().ToTable("Category");
            modelBuilder.Entity<Category>().HasMany(p => p.Books).WithOne(p => p.Category).HasForeignKey(p => p.CategoryId).OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Customer>().ToTable("Customer");
            modelBuilder.Entity<Customer>().HasMany(p => p.LoanReceipts).WithOne(p => p.Customer).HasForeignKey(p => p.CustomerId).OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Publisher>().ToTable("Publisher");
            modelBuilder.Entity<Publisher>().HasMany(p => p.Books).WithOne(p => p.Publisher).HasForeignKey(p => p.PublisherId).OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<User>().ToTable("User");
            modelBuilder.Entity<User>().HasMany(p => p.LoanReceipts).WithOne(p => p.Borrower).HasForeignKey(p => p.BorrowerId).OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<User>().HasMany(p=>p.CustomerCreated).WithOne(p => p.UserCreate).HasForeignKey(p => p.UserIdCreate).OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Book>().HasMany(p => p.LoanReceipts).WithOne(p => p.Book).HasForeignKey(p => p.BookId).OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<LoanReceipt>().HasKey(p=>p.LoanReceiptId);

            modelBuilder.Entity<Language>().HasMany(p => p.Book).WithOne(p => p.Language).HasForeignKey(p => p.LanguageId).OnDelete(DeleteBehavior.SetNull);

            modelBuilder.Entity<LoanStatus>().ToTable("LoanReceiptStatus").HasKey(p => p.StatusId);

            modelBuilder.Entity<LoanStatus>().HasOne(p => p.LoanReceipt).WithMany(p => p.StatusList).HasForeignKey(p => p.LoanReceiptId).OnDelete(DeleteBehavior.Cascade);
        }
    }
}

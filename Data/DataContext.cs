using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace QLTV
{
    public partial class DataContext : DbContext
    {
        public DataContext()
            : base("name=Model1")
        {
        }

        public virtual DbSet<author> authors { get; set; }
        public virtual DbSet<book> books { get; set; }
        public virtual DbSet<category> categories { get; set; }
        public virtual DbSet<language> languages { get; set; }
        public virtual DbSet<loan> loans { get; set; }
        public virtual DbSet<role> roles { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<user> users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<author>()
                .HasMany(e => e.books)
                .WithOptional(e => e.author)
                .HasForeignKey(e => e.author_id);

            modelBuilder.Entity<book>()
                .HasOptional(e => e.loan)
                .WithRequired(e => e.book);

            modelBuilder.Entity<language>()
                .HasOptional(e => e.book)
                .WithRequired(e => e.language);

            modelBuilder.Entity<user>()
                .HasMany(e => e.loans)
                .WithOptional(e => e.user)
                .HasForeignKey(e => e.user_id);
        }
    }
}

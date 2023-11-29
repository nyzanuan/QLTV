using QLTV.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTV.Data
{
    public class DataContext : DbContext
    {
        public DbSet<Author> authors;
        public DataContext() : base("Data Source=SQL5105.site4now.net;Initial Catalog=db_aa21b3_sa;User Id=db_aa21b3_sa_admin;Password=Long123@")
        {
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}

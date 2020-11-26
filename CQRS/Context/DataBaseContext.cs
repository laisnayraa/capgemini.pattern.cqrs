using CQRS.Configuration;
using CQRS.Models;
using CQRS.RequestModels.CommandRequestModels;
using CQRS.ResponseModels.CommandResponseModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CQRS
{
    public class DataBaseContext : DbContext
    {
        public DataBaseContext() { }
        public DataBaseContext(DbContextOptions<DataBaseContext> options) : base(options) { }
        public DbSet<Book> Book { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new BookConfiguration());
            base.OnModelCreating(modelBuilder);
        }
    }
}

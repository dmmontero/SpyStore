using Microsoft.EntityFrameworkCore;
using SpyStore.Models.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SpyStore.DAL.EF
{
    class StoreContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public StoreContext()
        {
        }
        public StoreContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Server=DNPWP38104\MSSQLSERVER_2016;Database=SpyStoreDB;Trusted_Connection=True;MultipleActiveResultSets=true;");
            }
        }
    }
}

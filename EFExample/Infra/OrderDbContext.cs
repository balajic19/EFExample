using EFExample.ViewModel;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFExample.Infra
{
    public class OrderDbContext : DbContext
    {
        public DbSet<OrderModel> OrderData { get; set; }

        public OrderDbContext()
        {
        }

        public OrderDbContext(DbContextOptions
<OrderDbContext> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\\mssqllocaldb;Database=OrderDb;Trusted_Connection=True;MultipleActiveResultSets=true");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WCF.Database.Entities;

namespace WCF.Database.Context
{
    class DatabaseContext:DbContext
    {
        public DatabaseContext() : base("TradeCompany")
        {
            this.Configuration.ProxyCreationEnabled = false;
            this.Configuration.LazyLoadingEnabled = false;
        
        }
        public DbSet<Заказчики> Customers { get; set; }

        public DbSet<Заказы> Orders { get; set; }

        public List<Заказчики> GetCustomers()
        {
            return Customers.Include("Заказы").ToList();
        }
        public List<Заказы> GetOrdersOfCustomer(int CustomerID)
        {
            return this.Orders.Where(Order => Order.id_заказчика == CustomerID).ToList();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Заказчики>()
                .HasMany(e => e.Заказы)
                .WithRequired(e => e.Заказчики)
                .HasForeignKey(e => e.id_заказчика);
        }
    }
}

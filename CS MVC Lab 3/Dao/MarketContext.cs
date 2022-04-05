using CS_MVC_Lab_3.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CS_MVC_Lab_3.Dao
{
    public class MarketContext : DbContext
    {
       
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
    }
}
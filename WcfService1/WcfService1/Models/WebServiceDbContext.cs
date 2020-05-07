using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WcfService1.Models;

namespace WcfService1.Models
{
    public class WebServiceDbContext : DbContext
    {
        public WebServiceDbContext()
            : base("name=WebServiceDbContext")
        {
        }
        public DbSet<Account> Accounts { get; set; }
    }
}

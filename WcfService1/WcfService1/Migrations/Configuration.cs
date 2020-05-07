namespace WcfService1.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using WcfService1.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<WcfService1.Models.WebServiceDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(WcfService1.Models.WebServiceDbContext context)
        {
            Account[] accounts =
            {
                new Account
                {
                    Id = 1,
                    CustomerCode = "account1",
                    Money = 10000,
                    Name = "Duy",
                    SercurityCode = "code01",
                },
                new Account
                {
                    Id = 2,
                    CustomerCode = "account2",
                    Money = 20000,
                    Name = "customer",
                    SercurityCode = "code02",
                }
               
            };
            context.Accounts.AddOrUpdate(accounts);
        }
    }
}

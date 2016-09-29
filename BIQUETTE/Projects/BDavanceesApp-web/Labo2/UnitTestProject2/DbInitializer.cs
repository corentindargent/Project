using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;
using System.Data.Entity;

namespace UnitTestProject2
{
    class DbInitializer : DropCreateDatabaseAlways<CompanyContext>
    {

        protected override void Seed(CompanyContext context)
        {
            Customer customer = new Customer()
            {
                AccountBalance = 545,
                AdresseLine1 = "Rue pont d'amour",
                AdresseLine2 = "numero 213",
                City = "Dinant",
                Country = "Belgique",
                Email = "etu27762@henallux.com",
                id = 1,
                Name = "Dargent",
                PostCode = "5500",
                Remark = "gdg"
            };
            
            context.Customers.Add(customer);
            context.SaveChanges();            

        }
    }
}

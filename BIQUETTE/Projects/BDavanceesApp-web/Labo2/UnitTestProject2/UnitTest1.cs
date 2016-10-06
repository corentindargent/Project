using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Data.Entity;
using ClassLibrary1;
using System.Linq;
using System.Data.Entity.Infrastructure;

namespace UnitTestProject2
{
    
    [TestClass]
    public class UnitTest1
    {
        [TestInitialize]      
        public void SetUp()
        {
            Database.SetInitializer(new DbInitializer());
            using (CompanyContext context = GetContext())
            {
                context.Database.Initialize(true);
            }
        }

        private CompanyContext GetContext()
        {
            return new CompanyContext();
        }
        [TestMethod]
        public void InsertionFonctionnelle()
        {
            using (var context = GetContext())
            {
                Assert.AreEqual(1, context.Customers.ToList().Count);
            }
        }


        [TestMethod]
        [ExpectedException(typeof(DbUpdateConcurrencyException))]
        public void DetectedTestEditionsConcurrentes()
        {
            using (CompanyContext contextDeJohn = GetContext())
            {
                using (CompanyContext contextDeSarah = GetContext())
                {
                    var clientDeJohn = contextDeJohn.Customers.First();
                    var clientDeSarah = contextDeSarah.Customers.First();

                    clientDeJohn.AccountBalance += 1000;
                    contextDeJohn.SaveChanges();

                    clientDeSarah.AccountBalance += 2000;
                    contextDeSarah.SaveChanges();
                }
            }
        }      
       
    }
}

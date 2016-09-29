using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Data.Entity;
using ClassLibrary1;
using System.Linq;

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
       
    }
}

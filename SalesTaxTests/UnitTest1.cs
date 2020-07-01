using Microsoft.VisualStudio.TestPlatform.Utilities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SalesTax.Accessors;
using SalesTax.Managers;
using System;

namespace SalesTaxTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void InputTest()
        {
            var manager = new TaxManager(new AccessorFactory());

            Assert.AreEqual(5.25m, manager.CalculateTax("USA", 100.00m));
            Assert.AreEqual(6.25m, manager.CalculateTax("CANADA", 100.00m));
            
        }

        [TestMethod]
        public void AmountNegativeOrZero()
        {
            var manager = new TaxManager(new AccessorFactory());
            
            Assert.AreEqual(-1, manager.CalculateTax("CANADA", -125.00m));
            Assert.AreEqual(-1, manager.CalculateTax("USA", -125.00m));
        }

        [TestMethod]
        public void TaxServiceNull()
        {
            var manager = new TaxManager(new AccessorFactory());
            
            Assert.AreEqual(-1, manager.CalculateTax("US", 125.00m));
            Assert.AreEqual(-1, manager.CalculateTax("", 125.00m));
        }
    }
}
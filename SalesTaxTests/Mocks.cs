using SalesTax.Accessors;
using System;
using System.Collections.Generic;
using System.Text;

namespace SalesTaxTests
{
    public class MockFactory : IAccessorFactory
    {
        public ITaxService MockTaxService { get; set; }
        public T CreateAccessor<T>(string subType = "") where T : class
        {

            if (typeof(T) == typeof(ITaxService))
            {
                return MockTaxService as T;
            }

            throw new ArgumentException();
        }
    }      

    public class MockTaxService : ITaxService
    {

        private decimal taxRate = 5.25m;
        private decimal result = 0.00m;
        private AccessorFactory accessorFactory;

        public MockTaxService()
        {
        }

        public void RequestTaxCalculation(decimal amount) => result = amount * (taxRate / 100);        

        public bool CheckTaxResult() => (result > 0.00m) ? true : false;
     
        public decimal GetTaxAmount() => result;

    }
}

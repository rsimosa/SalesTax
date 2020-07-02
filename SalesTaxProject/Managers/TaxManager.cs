using SalesTax.Accessors;
using System;
using System.Collections.Generic;
using System.Text;

namespace SalesTax.Managers
{
    public class TaxManager
    {

        private IAccessorFactory accessorFactory;

        public TaxManager(IAccessorFactory factory)
        {
            accessorFactory = factory;
        }

        public decimal CalculateTax(string country, decimal amount)
        {
            var taxService = accessorFactory.CreateAccessor<ITaxService>(country);

            if (taxService != null && amount > 0)
            {
                taxService.RequestTaxCalculation(amount);

                return (taxService.CheckTaxResult()) ? taxService.GetTaxAmount() : -1;
            }
            else
            {
                return -1;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace SalesTax.Accessors
{
    public class TaxServiceA : ITaxService
    {
        private decimal taxRate = 5.25m;
        private decimal result = 0.00m;

        public bool CheckTaxResult() => (result > 0.00m) ? true : false;

        public decimal GetTaxAmount() => result;

        public void RequestTaxCalculation(decimal amount) => result = amount * (taxRate / 100);

    }
}

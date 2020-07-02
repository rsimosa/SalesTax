using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace SalesTax.Accessors
{
    public interface ITaxService
    {
        void RequestTaxCalculation(decimal amount);
        bool CheckTaxResult();
        decimal GetTaxAmount();
    }
}

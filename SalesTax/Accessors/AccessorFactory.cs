using System;
using System.Collections.Generic;
using System.Text;

namespace SalesTax.Accessors
{
    public class AccessorFactory : IAccessorFactory
    {
        public T CreateAccessor<T>(string subType = "") where T : class
        {
            if (typeof(T) == typeof(ITaxService))
            {
                switch (subType)
                {
                    case "USA":
                        return new TaxServiceA() as T;
                    case "CANADA":
                        return new TaxServiceB() as T;
                    default:
                       return null;
                }
            }
            throw new ArgumentException("Tax Service Unavailable");            
        }
    }
}

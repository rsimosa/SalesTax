using SalesTax.Accessors;
using SalesTax.Managers;
using System;
using System.Runtime.ExceptionServices;

namespace SalesTax
{
    class Program
    {
        static void Main(string[] args)
        {
            //calculatetax
            var manager = new TaxManager(new AccessorFactory());

            Console.WriteLine(manager.CalculateTax("USA", 125.00m));

            Console.WriteLine(manager.CalculateTax("CANADA", 125.00m));

            Console.WriteLine(manager.CalculateTax("CANAD", 125.00m));

            Console.WriteLine(manager.CalculateTax("SA", 125.00m));
            Console.WriteLine(manager.CalculateTax("USA", 9999999999.99m));
        }
    }
}

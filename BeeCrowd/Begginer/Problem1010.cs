using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scripts.Classes.BeeCrowd.Begginer
{
    /// <summary>
    /// Simple calculate
    /// In this problem, the task is to read a code of a product 1, the number of units of product 1, 
    /// the price for one unit of product 1, the code of a product 2, the number of units of product 2 and the price for one unit of product 2. 
    /// After this, calculate and show the amount to be paid.
    /// </summary>
    internal class Problem1010
    {
        struct Product
        {
            public Product(int code, int quantity, double value)
            {
                Code = code;
                Quantity = quantity;
                Value = value;
            }

            public int Code { get; set; }
            public int Quantity { get; set; }
            public double Value { get; set; }

            public double TotalValue() => Value * Quantity;
        }

        static void Main()
        {
            int code, quantity;
            double value;

            string[] values = Console.ReadLine().Split();

            code = int.Parse(values[0], System.Globalization.CultureInfo.InvariantCulture);
            quantity = int.Parse(values[1], System.Globalization.CultureInfo.InvariantCulture);
            value = double.Parse(values[2], System.Globalization.CultureInfo.InvariantCulture);

            Product product1 = new Product(code, quantity, value);

            values = Console.ReadLine().Split();

            code = int.Parse(values[0], System.Globalization.CultureInfo.InvariantCulture);
            quantity = int.Parse(values[1], System.Globalization.CultureInfo.InvariantCulture);
            value = double.Parse(values[2], System.Globalization.CultureInfo.InvariantCulture);

            Product product2 = new Product(code, quantity, value);

            double totalValue = product1.TotalValue() + product2.TotalValue();

            Console.WriteLine($"VALOR A PAGAR: R$ {totalValue.ToString("N2", System.Globalization.CultureInfo.InvariantCulture).Replace(",", "")}");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scripts.Classes.BeeCrowd.Begginer
{
    /// <summary>
    /// Simple product
    /// Read two integer values. After this, calculate the product between them and store the result in a variable named PROD. 
    /// Print the result like the example below. 
    /// Do not forget to print the end of line after the result, otherwise you will receive “Presentation Error”.
    /// </summary>
    internal class Problem1004
    {
        static void Main()
        {
            int a, b;

            a = int.Parse(Console.ReadLine(), System.Globalization.CultureInfo.InvariantCulture);
            b = int.Parse(Console.ReadLine(), System.Globalization.CultureInfo.InvariantCulture);

            int product = a * b;

            Console.WriteLine($"PROD = {product}");
        }
    }
}

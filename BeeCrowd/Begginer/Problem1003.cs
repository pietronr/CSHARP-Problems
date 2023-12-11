using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scripts.Classes.BeeCrowd.Begginer
{
    /// <summary>
    /// Simple sum
    /// Read two integer values, in this case, the variables A and B. 
    /// After this, calculate the sum between them and assign it to the variable SOMA. 
    /// Write the value of this variable.
    /// </summary>
    internal class Problem1003
    {
        static void Main()
        {
            int a;
            int b;

            a = int.Parse(Console.ReadLine(), System.Globalization.CultureInfo.InvariantCulture);
            b = int.Parse(Console.ReadLine(), System.Globalization.CultureInfo.InvariantCulture);

            int sum = a + b;

            Console.WriteLine($"SOMA = {sum}");
        }
    }
}

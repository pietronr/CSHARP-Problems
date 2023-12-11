using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scripts.Classes.BeeCrowd.Begginer
{
    /// <summary>
    /// Extremely basic
    /// Read 2 variables, named A and B and make the sum of these two variables, assigning its result to the variable X. 
    /// Print X as shown below. Print endline after the result otherwise you will get “Presentation Error”.
    /// </summary>
    internal class Problem1001
    {
        static void Do(string[] args)
        {
            int a;
            int b;

            a = int.Parse(Console.ReadLine(), System.Globalization.CultureInfo.InvariantCulture);
            b = int.Parse(Console.ReadLine(), System.Globalization.CultureInfo.InvariantCulture);

            int x = a + b;

            Console.WriteLine($"X = {x}");
        }
    }
}

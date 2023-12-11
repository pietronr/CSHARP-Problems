using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scripts.Classes.BeeCrowd.Begginer
{
    /// <summary>
    /// Selection Test 1
    /// Read 4 integer values A, B, C and D. 
    /// Then if B is greater than C and D is greater than A and if the sum of C and D is greater 
    /// than the sum of A and B and if C and D were positives values and if A is even, 
    /// write the message “Valores aceitos” (Accepted values). 
    /// Otherwise, write the message “Valores nao aceitos” (Values not accepted).
    /// </summary>
    internal class Problem1035
    {
        static void Main()
        {
            int a, b, c, d;

            string[] values = Console.ReadLine().Split();

            a = int.Parse(values[0]);
            b = int.Parse(values[1]);
            c = int.Parse(values[2]);
            d = int.Parse(values[3]);

            bool isAccepted = b > c && d > a && ((c + d) > (a + b)) && c > 1 && d > 1 && a % 2 == 0;

            if (isAccepted)
            {
                Console.WriteLine("Valores aceitos");
            }
            else
            {
                Console.WriteLine("Valores nao aceitos");
            }
        }
    }
}

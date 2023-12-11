using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scripts.Classes.BeeCrowd.Begginer
{
    /// <summary>
    /// Greatest
    /// Make a program that reads 3 integer values and present the greatest one followed by the message "eh o maior"
    /// You should use the formula provided
    /// </summary>
    internal class Problem1013
    {
        static int GetGreatestValue(int a, int b)
        {
            return (a + b + Math.Abs(a - b)) / 2;
        }

        static void Main()
        {
            int a, b, c;

            string[] values = Console.ReadLine().Split();

            a = int.Parse(values[0]);
            b = int.Parse(values[1]);
            c = int.Parse(values[2]);

            int greatestAB = GetGreatestValue(a, b);
            int greatestBC = GetGreatestValue(b, c);

            int greatestOfAll = GetGreatestValue(greatestAB, greatestBC);

            Console.WriteLine($"{greatestOfAll} eh o maior");
        }
    }
}

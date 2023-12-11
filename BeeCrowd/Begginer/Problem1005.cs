using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scripts.Classes.BeeCrowd.Begginer
{
    /// <summary>
    /// Average 1
    /// Read two floating points' values of double precision A and B, corresponding to two student's grades. 
    /// After this, calculate the student's average, considering that grade A has weight 3.5 and B has weight 7.5. 
    /// Each grade can be from zero to ten, always with one digit after the decimal point. Don’t forget to print the end of line after the result, otherwise you will receive “Presentation Error”. 
    /// Don’t forget the space before and after the equal sign.
    /// </summary>
    static class Problem1005
    {
        static void Do(string[] args)
        {
            double a;
            double b;

            a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double average = (0.35 * a + 0.75 * b) / 1.1;

            Console.WriteLine($"MEDIA = {average:N5}");
        }
    }
}

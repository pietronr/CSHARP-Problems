using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scripts.Classes.BeeCrowd.Begginer
{
    /// <summary>
    /// Salary with bonus
    /// Make a program that reads a seller's name, his/her fixed salary and the sale's total made by himself/herself in the month (in money). 
    /// Considering that this seller receives 15% over all products sold, write the final salary (total) of this seller at the end of the month , with two decimal places.
    /// Don’t forget to print the line's end after the result, otherwise you will receive “Presentation Error”.
    /// Don’t forget the blank spaces.
    /// </summary>
    internal class Problem1009
    {
        static void Main()
        {
            string name;
            double salary, soldValue;

            name = Console.ReadLine().Trim();
            salary = double.Parse(Console.ReadLine(), System.Globalization.CultureInfo.InvariantCulture);
            soldValue = double.Parse(Console.ReadLine(), System.Globalization.CultureInfo.InvariantCulture);

            double bonus = soldValue * 0.15;
            double total = salary + bonus;

            Console.WriteLine($"TOTAL = R$ {total.ToString("N2", System.Globalization.CultureInfo.InvariantCulture).Replace(",", "")}");
        }
    }
}

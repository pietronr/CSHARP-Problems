using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scripts.Classes.BeeCrowd.Begginer
{
    /// <summary>
    /// Salary
    /// Write a program that reads an employee's number, his/her worked hours number in a month and the amount he received per hour. 
    /// Print the employee's number and salary that he/she will receive at end of the month, with two decimal places.
    /// Don’t forget to print the line's end after the result, otherwise you will receive “Presentation Error”.
    /// Don’t forget the space before and after the equal signal and after the U$.
    /// </summary>
    internal class Problem1008
    {
        static void Main()
        {
            int number, hours;
            double valuePerHour;

            number = int.Parse(Console.ReadLine(), System.Globalization.CultureInfo.InvariantCulture);
            hours = int.Parse(Console.ReadLine(), System.Globalization.CultureInfo.InvariantCulture);
            valuePerHour = double.Parse(Console.ReadLine(), System.Globalization.CultureInfo.InvariantCulture);

            double salary = hours * valuePerHour;

            Console.WriteLine($"NUMBER = {number}");
            Console.WriteLine($"SALARY = U$ {salary.ToString("N2", System.Globalization.CultureInfo.InvariantCulture).Replace(",", "")}");
        }
    }
}

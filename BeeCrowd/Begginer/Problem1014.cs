using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scripts.Classes.BeeCrowd.Begginer
{
    /// <summary>
    /// Consumption
    /// Calculate a car's average consumption being provided the total distance traveled (in Km) and the spent fuel total (in liters).
    /// </summary>
    internal class Problem1014
    {
        static void Main()
        {
            int km;
            double fuel;

            km = int.Parse(Console.ReadLine());
            fuel = double.Parse(Console.ReadLine(), System.Globalization.CultureInfo.InvariantCulture);

            double kmPerLiter = km / fuel;

            Console.WriteLine($"{kmPerLiter.ToString("N3", System.Globalization.CultureInfo.InvariantCulture).Replace(",", "")} km/l");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scripts.Classes.BeeCrowd.Begginer
{
    internal class Problem1017
    {
        static void Main()
        {
            const double kmPerLiter = 12.0;

            int hours, kmPerHour;

            hours = int.Parse(Console.ReadLine());
            kmPerHour = int.Parse(Console.ReadLine());

            int totalKm = hours * kmPerHour;

            double litersNeeded = totalKm / kmPerLiter;

            Console.WriteLine(litersNeeded.ToString("N3", System.Globalization.CultureInfo.InvariantCulture).Replace(",", ""));
        }
    }
}

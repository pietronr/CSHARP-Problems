using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scripts.Classes.BeeCrowd.Begginer
{
    /// <summary>
    /// Time conversion
    /// Read an integer value, which is the duration in seconds of a certain event in a factory, 
    /// and inform it expressed in hours:minutes:seconds.
    /// </summary>
    internal class Problem1019
    {
        static void Main()
        {
            int value;

            value = int.Parse(Console.ReadLine());
            
            int hours, minutes, seconds;
            hours = minutes = seconds = 0;
            int result;

            while (value > 0)
            {
                if (value > 3600)
                {
                    result = value / 3600;
                    value -= result * 3600;
                    hours += 1 * result;
                }
                else if (value > 60)
                {
                    result = value / 60;
                    value -= result * 60;
                    minutes += 1 * result;
                }
                else
                {
                    result = value;
                    value -= result;
                    seconds += result;
                }
            }

            Console.WriteLine($"{hours}:{minutes}:{seconds}");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scripts.Classes.BeeCrowd.Begginer
{
    /// <summary>
    /// Interval
    /// You must make a program that read a float-point number and print a message saying in which of following intervals the 
    /// number belongs: [0,25] (25,50], (50,75], (75,100]. 
    /// If the read number is less than zero or greather than 100, 
    /// the program must print the message “Fora de intervalo” that means "Out of Interval".

    /// The symbol '(' represents greather than.For example:
    /// [0,25] indicates numbers between 0 and 25.0000, including both.
    /// (25,50] indicates numbers greather than 25 (25.00001) up to 50.0000000.
    /// </summary>
    internal class Problem1037
    {
        static void Main()
        {
            double value;
            value = double.Parse(Console.ReadLine(), System.Globalization.CultureInfo.InvariantCulture);

            if (value < 0 || value > 100)
            {
                Console.WriteLine("Fora de intervalo");
            }
            else if (value <= 25)
            {
                Console.WriteLine("Intervalo [0,25]");
            }
            else if (value <= 50)
            {
                Console.WriteLine("Intervalo (25,50]");
            }
            else if (value <= 75)
            {
                Console.WriteLine("Intervalo (50,75]");
            }
            else
            {
                Console.WriteLine("Intervalo (75,100]");
            }
        }
    }
}

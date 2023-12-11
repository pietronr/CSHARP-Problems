using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scripts.Classes.BeeCrowd.Begginer
{
    /// <summary>
    /// Even, Odd, Positive and Negative
    /// Make a program that reads five integer values. 
    /// Count how many   of these values are even, odd, positive and negative. 
    /// Print these information like following example.
    /// </summary>
    internal class Problem1066
    {
        static void Main()
        {
            int value;
            int evens, odds, positives, negatives;

            evens = odds = positives = negatives = 0;

            for (int i = 0; i < 5 ; i++)
            {
                value = int.Parse(Console.ReadLine());

                if (value % 2 == 0)
                {
                    evens++;
                }
                else
                {
                    odds++;
                }

                if (value > 0)
                {
                    positives++;
                }
                else if (value < 0)
                {
                    negatives++;
                }
            }

            Console.WriteLine($"{evens} valor(es) par(es)");
            Console.WriteLine($"{odds} valor(es) impar(es)");
            Console.WriteLine($"{positives} valor(es) positivo(s)");
            Console.WriteLine($"{negatives} valor(es) negativo(s)");
        }
    }
}

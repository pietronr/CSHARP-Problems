using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scripts.Classes.BeeCrowd.Begginer
{
    /// <summary>
    /// Banknotes
    /// In this problem you have to read an integer value and calculate the smallest possible number of banknotes in which the value may be decomposed. 
    /// The possible banknotes are 100, 50, 20, 10, 5, 2 and 1. 
    /// Print the read value and the list of banknotes.
    /// </summary>
    static class Problem1018
    {
        static void Do(string[] args)
        {
            int n100, n50, n20, n10, n5, n2, n1;
            n100 = n50 = n20 = n10 = n5 = n2 = n1 = 0;

            int input, auxInput;
            int result;

            input = auxInput = int.Parse(Console.ReadLine(), System.Globalization.CultureInfo.InvariantCulture);

            int getResult(int factor)
            {
                result = input / factor;
                input -= result * factor;
                return result;
            }

            while (input > 0)
            {
                if (input >= 100)
                {
                    n100 += getResult(100);
                }
                else if (input >= 50)
                {
                    n50 += getResult(50);
                }
                else if (input >= 20)
                {
                    n20 += getResult(20);
                }
                else if (input >= 10)
                {
                    n10 += getResult(10);
                }
                else if (input >= 5)
                {
                    n5 += getResult(5);
                }
                else if (input >= 2)
                {
                    n2 += getResult(2);
                }
                else
                {
                    n1 += getResult(1);
                }
            }

            Console.WriteLine(auxInput);
            Console.WriteLine($"{n100} nota(s) de R$ 100,00");
            Console.WriteLine($"{n50} nota(s) de R$ 50,00");
            Console.WriteLine($"{n20} nota(s) de R$ 20,00");
            Console.WriteLine($"{n10} nota(s) de R$ 10,00");
            Console.WriteLine($"{n5} nota(s) de R$ 5,00");
            Console.WriteLine($"{n2} nota(s) de R$ 2,00");
            Console.WriteLine($"{n1} nota(s) de R$ 1,00");
        }
    }
}

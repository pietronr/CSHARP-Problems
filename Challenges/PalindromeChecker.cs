using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scripts.Classes.Challenges
{
    /// <summary>
    /// Read a string from console and check if it's a palindrome.
    /// </summary>
    internal static class PalindromeChecker
    {
        static void Main()
        {
            string value = Console.ReadLine()!;
            char[] inverse = new char[value.Length];

            bool areEqual = true;

            int lastIndex = value.Length - 1;

            for (int i = 0; i < value!.Length; i++)
            {
                inverse[lastIndex - i] = value[i];

                if (!inverse[lastIndex - i].Equals(value[lastIndex - i]))
                {
                    areEqual = false;
                }
            }

            Console.WriteLine(inverse);

            if (areEqual)
            {
                Console.WriteLine("É um palíndromo!");
            }
        }
    }
}

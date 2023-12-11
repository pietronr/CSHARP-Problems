namespace Scripts.Classes.Operations
{
    public static class MathOperations
    {
        /// <summary>
        /// Returns the sum of all the elements from the <paramref name="array"/> array.
        /// </summary>
        /// <param name="array">
        /// Array of <see cref="int"/> numbers.
        /// </param>
        /// <returns></returns>
        public static int Sum(int[] array)
        {
            int sum = 0;

            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }

            return sum;
        }

        /// <summary>
        /// Returns the product of factors <paramref name="x"/> and <paramref name="y"/>.
        /// </summary>
        /// <param name="x">
        /// Factor 1 used in the multiplication.
        /// </param>
        /// <param name="y">
        /// Factor 2 used in the multiplication.
        /// </param>
        /// <returns></returns>
        public static int PrimitiveMultiplication(int x, int y)
        {
            int product = 0;

            while (y > 0)
            {
                product += x;
                y--;
            }

            return product;
        }

        /// <summary>
        /// Determines if the int <paramref name="number"/> is a boolean or not.
        /// </summary>
        /// <param name="number">
        /// <see cref="int"/> number that will be analysed.
        /// </param>
        /// <returns></returns>
        public static bool IsPrimeNumber(int number)
        {
            for (int i = number - 1; i >= 1; i--)
            {
                if (number % i == 0 && i != 1)
                {
                    return false;
                }
            }

            return true;
        }
    }
}

using Scripts.Helpers;

namespace Scripts.Classes.Operations
{
    public static class ArrayOperations
    {
        /// <summary>
        /// Algorithm that iterates the <paramref name="array"/> array and returns the position where <paramref name="k"/> is.
        /// If it doesn't find the value, it returns -1.
        /// </summary>
        /// <param name="array">
        /// <see cref="int"/> array that will be fully iterated, starting at index 0, until it finds (or not) the specified <paramref name="k"/> value.
        /// </param>
        /// <param name="k">
        /// <see cref="int"/> value that will be searched in the array.
        /// </param>
        /// <returns></returns>
        public static int LinearSearch(int[] array, int k)
        {
            int i = 0;

            while (i < array.Length && array[i] != k)
            {
                i++;
            }

            if (i < array.Length && array[i] == k)
            {
                return i;
            }

            return -1;
        }

        /// <summary>
        /// Recursive algorithm that iterates the <paramref name="array"/> and returns the position where <paramref name="k"/> is, 
        /// using the Divide and Conquer method, between the pivots <paramref name="l"/> and <paramref name="r"/>.
        /// It splits the array in parts, using the right slice if the value found is lesser than <paramref name="k"/> and the left slice if it's greater than <paramref name="k"/>.
        /// Returns -1 if no value is found.
        /// </summary>
        /// <param name="array">
        /// The array that will be iterated.
        /// </param>
        /// <param name="k">
        /// The key value that will be searched.
        /// </param>
        /// <param name="l">
        /// Determines the left index to be used as a pivot.
        /// </param>
        /// <param name="r">
        /// Determines the right index to be used as a pivot.
        /// </param>
        /// <returns></returns>
        public static int BinarySearch(int[] array, int k, int? l = null, int? r = null)
        {
            int lPivot = l == null ? 0 : l.TryValue();
            int rPivot = r == null ? array.Length - 1 : r.TryValue();

            if (rPivot >= lPivot)
            {
                int index = lPivot + (rPivot - lPivot) / 2;

                if (array[index] == k)
                {
                    return index;
                }
                else if (array[index] < k)
                {
                    return BinarySearch(array, k, index + 1, rPivot);
                }
                else if (array[index] > k)
                {
                    return BinarySearch(array, k, lPivot, index - 1);
                }
            }

            return -1;
        }

        /// <summary>
        /// Returns a slice from the <paramref name="array"/>, starting from the <paramref name="startIndex"/> onwards until the <paramref name="endIndex"/>.
        /// </summary>
        /// <param name="startIndex">
        /// The start index for the slicing.
        /// </param>
        /// <param name="endIndex">
        /// The last index for the slicing.
        /// </param>
        /// <param name="array">
        /// The array to be sliced.
        /// </param>
        /// <returns></returns>
        public static int[] SliceArray(int[] array, int startIndex, int? endIndex = null)
        {
            int actualEndIndex = endIndex == null ? array.Length : endIndex.TryValue() + 1;

            int[] slice = new int[actualEndIndex - startIndex];

            int j = 0;
            for (int i = startIndex; i < actualEndIndex; i++)
            {
                slice[j] = array[i];
                j++;
            }

            return slice;
        }

        /// <summary>
        /// Returns the largest number inside the <paramref name="array"/>.
        /// </summary>
        /// <param name="array">
        /// <see cref="int"/> array that will be iterated.
        /// </param>
        /// <returns></returns>
        public static int GetLargestNumber(int[] array)
        {
            int largestNumber = array[0];

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > largestNumber)
                {
                    largestNumber = array[i];
                }
            }

            return largestNumber;
        }
    }
}

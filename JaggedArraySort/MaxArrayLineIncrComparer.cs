﻿using JaggedArraySort.Comparer;

namespace JaggedArraySort
{
    /// <summary>
    /// Comparator two integer arrays
    /// </summary>
    public class MaxArrayLineIncrComparer : IComparer
    {
        /// <summary>
        /// Compare two integer arrays
        /// </summary>
        /// <param name="array1">First array</param>
        /// <param name="array2">Second array</param>
        /// <returns>difference from first to second array</returns>
        /// <returns>number -1 if array1 is null</returns>
        /// <returns>number 1 if array2 is null</returns>
        public int Compare(int[] array1, int[] array2)
        {
            if (array1 == null)
            {
                return -1;
            }

            if (array2 == null)
            {
                return 1;
            }

            return MaxCalculate.MaxArrLine(array1) - MaxCalculate.MaxArrLine(array2);
        }
    }
}
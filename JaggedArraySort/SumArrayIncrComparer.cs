using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JaggedArraySort.Comparer;

namespace JaggedArraySort
{
    /// <summary>
    /// Compare two integer arrays
    /// </summary>
    public class SumArrayIncrComparer : IComparer
    {
        /// <summary>
        /// Compare two integer arrays
        /// </summary>
        /// <param name="array1">First array</param>
        /// <param name="array2">Second array</param>
        /// <returns>difference from first to second array</returns>
        /// <returns>number -1 if array1 is null</returns>
        public int Compare(int[] array1, int[] array2)
        {
            if (array1 == null)
            {
                return -1;
            }

            return SumCalculate.SumArrLine(array1) - SumCalculate.SumArrLine(array2);
        }
    }
}

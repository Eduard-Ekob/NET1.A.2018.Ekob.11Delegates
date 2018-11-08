using JaggedArraySort.Comparer;

namespace JaggedArraySort
{
    /// <summary>
    /// Comparator two integer arrays
    /// </summary>
    public class SumArrayDecrComparer : IComparer
    {
        /// <summary>
        /// Compare two integer arrays
        /// </summary>
        /// <param name="array1">First array</param>
        /// <param name="array2">Second array</param>
        /// <returns>difference from second to first array</returns>
        /// <returns>number -1 if array2 is null</returns>
        public int Compare(int[] array1, int[] array2)
        {
            if (array2 == null)
            {
                return -1;
            }

            return SumCalculate.SumArrLine(array2) - SumCalculate.SumArrLine(array1);
        }
    }
}
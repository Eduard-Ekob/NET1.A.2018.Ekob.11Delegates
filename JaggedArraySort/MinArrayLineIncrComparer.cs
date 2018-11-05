using JaggedArraySort.Comparer;

namespace JaggedArraySort
{
    public class MinArrayLineIncrComparer : IComparer
    {
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

            return MinCalculate.MinArrLine(array1) - MinCalculate.MinArrLine(array2);
        }
    }
}
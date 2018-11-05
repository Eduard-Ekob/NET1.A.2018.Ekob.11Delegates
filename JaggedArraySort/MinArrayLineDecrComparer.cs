using JaggedArraySort.Comparer;

namespace JaggedArraySort
{
    public class MinArrayLineDecrComparer : IComparer
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

            return MinCalculate.MinArrLine(array2) - MinCalculate.MinArrLine(array1);
        }
    }
}
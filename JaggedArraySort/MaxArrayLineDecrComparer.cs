using JaggedArraySort.Comparer;

namespace JaggedArraySort
{
    public class MaxArrayLineDecrComparer : IComparer
    {
        public int Compare(int[] array1, int[] array2)
        {
            if (array1 == null)
            {
                return 1;
            }

            if (array2 == null)
            {
                return -1;
            }

            return MaxCalculate.MaxArrLine(array2) - MaxCalculate.MaxArrLine(array1);
        }
    }
}
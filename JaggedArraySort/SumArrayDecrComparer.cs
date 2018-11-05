using JaggedArraySort.Comparer;

namespace JaggedArraySort
{
    public class SumArrayDecrComparer : IComparer
    {        
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
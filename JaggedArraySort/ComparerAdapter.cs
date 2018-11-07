using JaggedArraySort.Comparer;

namespace JaggedArraySort
{
    public delegate int Comparator(int[] arr1, int[] arr2);
    public class ComparerAdapter : IComparer
    {
        private Comparator comparator;

        public ComparerAdapter(Comparator comparator)
        {
            this.comparator = comparator;
        }
        public int Compare(int[] array1, int[] array2)
        {
            return comparator(array1, array2);
        }
    }
}
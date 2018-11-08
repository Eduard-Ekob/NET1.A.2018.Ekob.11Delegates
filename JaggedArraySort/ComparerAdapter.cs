using JaggedArraySort.Comparer;

namespace JaggedArraySort
{
    /// <summary>
    /// The Comparator is delegate which incapsulated method
    /// for compare two integer arrays
    /// </summary>
    /// <param name="arr1">First incomming array</param>
    /// <param name="arr2">Second incomming array</param>
    /// <returns>comparing value</returns>
    public delegate int Comparator(int[] arr1, int[] arr2);

    /// <summary>
    /// Adapter for convert method incapsulated in delegate to IComparer interface
    /// </summary>
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
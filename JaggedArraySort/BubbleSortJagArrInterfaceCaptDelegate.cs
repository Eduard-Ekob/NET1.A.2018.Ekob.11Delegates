using JaggedArraySort.Comparer;
using System;

namespace JaggedArraySort
{
    public static class BubbleSortJagArrInterfaceCaptDelegate
    {
        /// <summary>
        /// The method BubbleSort for sort jagged array captured overloaded delegate
        /// </summary>
        /// <param name="jagArr">jagArr is incomming jagged array for sort</param>
        /// <param name="comparer">comparer is strategy(method) for sort</param>
        /// <exception cref="ArgumentNullException">If incomming array is null</exception>
        public static void BubbleSort(int[][] jagArr, IComparer comparer)
        {
            if (jagArr == null)
            {
                throw new ArgumentNullException(nameof(jagArr));
            }

            if (comparer == null)
            {
                throw new ArgumentNullException(nameof(comparer));
            }

            Comparator comparator = comparer.Compare;
            BubbleSort(jagArr, comparator);
        }

        /// <summary>
        /// The method BubbleSort for sort jagged array
        /// </summary>
        /// <param name="jArr">jArr is incomming jagged array for sort</param>
        /// <param name="comparator">comparer is is delegate which incapsulate method for strategy</param>
        /// <exception cref="ArgumentNullException">If incomming array is null</exception>
        public static void BubbleSort(int[][] jArr, Comparator comparator)
        {
            if (jArr == null)
            {
                throw new ArgumentNullException(nameof(jArr));
            }

            if (comparator == null)
            {
                throw new ArgumentNullException(nameof(comparator));
            }

            for (int i = 0; i < jArr.Length; i++)
            {
                for (int j = i + 1; j < jArr.Length; j++)
                {
                    if (comparator(jArr[i], jArr[j]) > 0)
                    {
                        Swap(ref jArr[i], ref jArr[j]);
                    }
                }
            }
        }

        private static void Swap(ref int[] arrF, ref int[] arrS)
        {
            var tempArr = arrF;
            arrF = arrS;
            arrS = tempArr;
        }
    }
}

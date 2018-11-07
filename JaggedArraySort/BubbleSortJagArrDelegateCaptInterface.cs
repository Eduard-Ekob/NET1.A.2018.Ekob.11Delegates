﻿using System;
using System.Collections.Generic;
using JaggedArraySort.Comparer;

namespace JaggedArraySort
{    
    public static class BubbleSortJagArrDelegateCaptInterface
    {
        /// <summary>
        /// The method BubbleSort for sort jagged array
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

            for (int i = 0; i < jagArr.Length; i++)
            {
                for (int j = i + 1; j < jagArr.Length; j++)
                {
                    if (comparer.Compare(jagArr[i], jagArr[j]) > 0)
                    {
                        Swap(ref jagArr[i], ref jagArr[j]);
                    }
                }
            }
        }
                    
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
            IComparer comparerAdapter = new ComparerAdapter(comparator);
            BubbleSort(jArr, comparerAdapter);
        }

        private static void Swap(ref int[] arrF, ref int[] arrS)
        {
            var tempArr = arrF;
            arrF = arrS;
            arrS = tempArr;
        }     
    }

}

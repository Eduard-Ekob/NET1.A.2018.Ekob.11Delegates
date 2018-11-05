using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JaggedArraySort.Comparer;

namespace JaggedArraySort
{
    public class SumArrayIncrComparer : IComparer
    {
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

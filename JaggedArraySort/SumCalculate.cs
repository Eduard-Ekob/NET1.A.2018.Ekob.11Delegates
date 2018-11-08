namespace JaggedArraySort
{
    /// <summary>
    /// Calculate sum of integer array
    /// </summary>
    public static class SumCalculate
    {
        /// <summary>
        /// Calculate sum elements of integer array
        /// </summary>
        /// <param name="arr1">Incomming array</param>
        /// <returns>sum value of array</returns>
        public static int SumArrLine(int[] arr)
        {
            int sum = 0;
            if (arr != null)
                for (int i = 0; i < arr.Length; i++)
                {
                    sum += arr[i];
                }

            return sum;
        }
    }
}
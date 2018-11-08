namespace JaggedArraySort
{
    /// <summary>
    /// Calculate maximum value element of integer array
    /// </summary>
    public static class MaxCalculate
    {
        public static int MaxArrLine(int[] arr)
        {
            /// <summary>
            /// Calculate maximum element of integer array
            /// </summary>
            /// <returns>maximum value of array</returns>
            int max = arr[0];
            var minInd = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (max < arr[i])
                {
                    max = arr[i];
                    minInd = i;
                }
            }

            return arr[minInd];
        }
    }
}
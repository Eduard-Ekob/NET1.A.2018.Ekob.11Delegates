namespace JaggedArraySort
{
    public static class MaxCalculate
    {
        public static int MaxArrLine(int[] arr)
        {
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
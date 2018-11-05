namespace JaggedArraySort
{
    public static class MinCalculate
    {
        public static int MinArrLine(int[] arr)
        {
            int min = arr[0];
            var minInd = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (min > arr[i])
                {
                    min = arr[i];
                    minInd = i;
                }
            }
            return arr[minInd];
        }
    }
}
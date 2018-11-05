namespace JaggedArraySort
{
    public static class SumCalculate
    {
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
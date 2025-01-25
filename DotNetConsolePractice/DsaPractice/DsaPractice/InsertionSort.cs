namespace DsaPractice
{
    internal class InsertionSort
    {
        public void Sort(int[] array)
        {
            int itemsCount = array.Length;
            for (int i = 1; i < itemsCount; i++)
            {
                int currentNumber = array[i];
                int j = i - 1;
                while (j >= 0 && array[j] > currentNumber)
                {
                    array[j + 1] = array[j];
                    j--;
                }
                array[j + 1] = currentNumber;
            }
        }
    }
}

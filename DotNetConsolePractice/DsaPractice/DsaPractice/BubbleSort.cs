namespace DsaPractice
{
    internal class BubbleSort
    {
        void SwapArrayItems(int[] array, int index1, int index2)
        {
            array[index1] += array[index2];
            array[index2] = array[index1] - array[index2];
            array[index1] -= array[index2];
        }
        public void Sort(int[] arrayToSort)
        {
            int arrayLength = arrayToSort.Length;
            bool isSorted = false;
            for (int i = 0; i < arrayLength; i++)
            {
                isSorted = true;
                for(int j = 0; j < arrayLength - 1 - i; j++)
                {
                    if (arrayToSort[j] > arrayToSort[j+1])
                    {
                        SwapArrayItems(arrayToSort, j, j+1);
                        isSorted = false;
                    }
                }
                if (isSorted) return;
            }
        }
    }
}

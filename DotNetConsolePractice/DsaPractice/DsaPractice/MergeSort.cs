namespace DsaPractice
{
    internal class MergeSort
    {
        public void MergeAndSort(int[] inputArray, bool ascending = true)
        {
            int arrayLength = inputArray.Length;
            if (arrayLength < 2) return;
            int halfCount = arrayLength / 2;
            int[] leftHalf = new int[halfCount];
            int[] rightHalf = new int[arrayLength - halfCount];
            for (int i = 0; i < halfCount; i++)
            {
                leftHalf[i] = inputArray[i];
            }
            for (int i = halfCount; i < arrayLength; i++)
            {
                rightHalf[i - halfCount] = inputArray[i];
            }

            MergeAndSort(leftHalf);
            MergeAndSort(rightHalf);
            Merge(leftHalf, rightHalf, inputArray);
        }

        void Merge(int[] leftHalf, int[] rightHalf, int[] inputArray)
        {
            int leftSize = leftHalf.Length;
            int rightSize = rightHalf.Length;
            int l = 0, r = 0, i = 0;
            while (l < leftSize && r < rightSize)
            {
                if (leftHalf[l] <= rightHalf[r])
                {
                    inputArray[i] = leftHalf[l];
                    l++;
                }
                else
                {
                    inputArray[i] = rightHalf[r];
                    r++;
                }
                i++;
            }

            while (l < leftSize)
            {
                inputArray[i] = leftHalf[l];
                l++;
                i++;
            }
            while (r < rightSize)
            {
                inputArray[i] = rightHalf[r];
                r++;
                i++;
            }
        }
        /*
        // Merge Sort by github copilot
        public void Sort(int[] array)
        {
            Sort(array, 0, array.Length - 1);
        }
        private void Sort(int[] array, int lowIndex, int highIndex)
        {
            if (lowIndex >= highIndex) return;
            int middleIndex = (lowIndex + highIndex) / 2;
            Sort(array, lowIndex, middleIndex);
            Sort(array, middleIndex + 1, highIndex);
            Merge(array, lowIndex, middleIndex, highIndex);
        }
        private void Merge(int[] array, int lowIndex, int middleIndex, int highIndex)
        {
            int[] leftArray = new int[middleIndex - lowIndex + 1];
            int[] rightArray = new int[highIndex - middleIndex];
            for (int i = 0; i < leftArray.Length; i++)
            {
                leftArray[i] = array[lowIndex + i];
            }
            for (int i = 0; i < rightArray.Length; i++)
            {
                rightArray[i] = array[middleIndex + 1 + i];
            }
            int leftPointer = 0;
            int rightPointer = 0;
            int mainPointer = lowIndex;
            while (leftPointer < leftArray.Length && rightPointer < rightArray.Length)
            {
                if (leftArray[leftPointer] <= rightArray[rightPointer])
                {
                    array[mainPointer] = leftArray[leftPointer];
                    leftPointer++;
                }
                else
                {
                    array[mainPointer] = rightArray[rightPointer];
                    rightPointer++;
                }
                mainPointer++;
            }
            while (leftPointer < leftArray.Length)
            {
                array[mainPointer] = leftArray[leftPointer];
                leftPointer++;
                mainPointer++;
            }
            while (rightPointer < rightArray.Length)
            {
                array[mainPointer] = rightArray[rightPointer];
                rightPointer++;
                mainPointer++;
            }
        }
        */
    }
}

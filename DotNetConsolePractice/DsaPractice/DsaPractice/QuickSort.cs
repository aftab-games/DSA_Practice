using System;

namespace DsaPractice
{
    internal class QuickSort
    {
        void Sort(int[] array, int lowIndex, int highIndex)
        {
            if (lowIndex >= highIndex) return;
            int pivotIndex = new Random().Next(highIndex - lowIndex) + lowIndex;
            int pivot = array[pivotIndex];
            Utils.SwapArrayItems(array, pivotIndex, highIndex);
            int leftPointer = lowIndex;
            int rightPointer = highIndex;

            while (leftPointer < rightPointer)
            {
                while (array[leftPointer] <= pivot && leftPointer < rightPointer)
                {
                    leftPointer++;
                }
                while (array[rightPointer] >= pivot && leftPointer < rightPointer)
                {
                    rightPointer--;
                }
                Utils.SwapArrayItems(array, leftPointer, rightPointer);
            }
            Utils.SwapArrayItems(array, leftPointer, highIndex);

            Sort(array, lowIndex, leftPointer - 1);
            Sort(array, leftPointer + 1, highIndex);
        }
        public void Sort(int[] array)
        {
            Sort(array, 0, array.Length - 1);
        }

        /*
        // Quick Sort by github copilot
        public void Sort(int[] array)
        {
            Sort(array, 0, array.Length - 1);
        }
        private void Sort(int[] array, int start, int end)
        {
            if (start >= end)
            {
                return;
            }
            int pivot = Partition(array, start, end);
            Sort(array, start, pivot - 1);
            Sort(array, pivot + 1, end);
        }
        private int Partition(int[] array, int start, int end)
        {
            int pivot = array[end];
            int i = start - 1;
            for (int j = start; j < end; j++)
            {
                if (array[j] < pivot)
                {
                    i++;
                    Swap(array, i, j);
                }
            }
            Swap(array, i + 1, end);
            return i + 1;
        }
        private void Swap(int[] array, int i, int j)
        {
            int temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }
        */
    }
}

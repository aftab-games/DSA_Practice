using System;

namespace Aftab.DSA.Sort
{
	public class Program
	{
		public static void Main(string[] args)
		{
            Random randomNumber = new Random();
            int[] myArray = new int[10]; // {9, 3, 5, 2, 6, 1, 8, 4, 14, 17, 3, 7, 3, 25};
            for (int i = 0; i < myArray.Length; i++)
            {
                myArray[i] = randomNumber.Next(20);
            }
            Console.WriteLine("Unsorted Array: " + string.Join(", ", myArray));
            QuickSort quickSort = new QuickSort();
            quickSort.Sort(myArray);
            Console.WriteLine("Sorted Array: " + string.Join(", ", myArray));
        }
	}
	
	public class QuickSort
    {
        void SwapItemsOfArray(int[] items, int index1, int index2)
        {
            int tempVal = items[index1];
            items[index1] = items[index2];
            items[index2] = tempVal;
        }

        public void Sort(int[] array)
        {
            Sort(array, 0, array.Length - 1);
        }

        void Sort(int[] array, int lowIndex, int highIndex)
        {
            if (lowIndex >= highIndex) return;
            int pivotIndex = new Random().Next(highIndex - lowIndex) + lowIndex;
            int pivot = array[pivotIndex];
            SwapItemsOfArray(array, pivotIndex, highIndex);
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
                SwapItemsOfArray(array, leftPointer, rightPointer);
            }
            SwapItemsOfArray(array, leftPointer, highIndex);

            Sort(array, lowIndex, leftPointer - 1);
            Sort(array, leftPointer + 1, highIndex);
        }
    }
}
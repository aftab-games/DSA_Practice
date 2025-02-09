using System;

namespace DsaPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BubbleSort();
            QuickSort();
            MergeSort();
            InsertionSort();
        }

        static void BubbleSort()
        {
            int[] myArray = Utils.GenerateRandomArray(10, 20);
            Utils.PrintArray("Bubble Sort - Unsorted: ", myArray);
            BubbleSort bubbleSort = new BubbleSort();
            bubbleSort.Sort(myArray);
            Utils.PrintArray("Bubble Sort - Sorted: ", myArray);
        }

        static void InsertionSort()
        {
            int[] myArray = new int[10];
            myArray = Utils.GenerateRandomArray(10, 20);
            Utils.PrintArray("Insertion Sort - Unsorted: ", myArray);
            InsertionSort insertionSort = new InsertionSort();
            insertionSort.Sort(myArray);
            Utils.PrintArray("Insertion Sort - Sorted: ", myArray);
        }

        static void QuickSort()
        {
            int[] myArray = new int[10];
            myArray = Utils.GenerateRandomArray(10, 20);
            Utils.PrintArray("Quick Sort - Unsorted: ", myArray);
            QuickSort quickSort = new QuickSort();
            quickSort.Sort(myArray);
            Utils.PrintArray("Quick Sort - Sorted: ", myArray);
        }

        static void MergeSort()
        {
            int[] myArray = new int[10];
            myArray = Utils.GenerateRandomArray(10, 20);
            Utils.PrintArray("Merge Sort - Unsorted: ", myArray);
            MergeSort mergeSort = new MergeSort();
            mergeSort.MergeAndSort(myArray);
            Utils.PrintArray("Merge Sort - Sorted: ", myArray);
        }
    }
}

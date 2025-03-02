using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace DsaPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AArray array = new AArray(3);
            array.Insert(5);
            array.Insert(2);
            array.Insert(9);
            array.Insert(7);
            array.PrintAArray();
            Console.WriteLine("Removing at 1");
            array.RemoveAt(1);
            array.PrintAArray();
            Console.WriteLine("Index of 7");
            Console.WriteLine(array.IndexOf(7));
            //PracticeString.Paractice();
            //BubbleSort();
            //QuickSort();
            //MergeSort();
            //InsertionSort();

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

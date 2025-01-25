using System;

namespace DsaPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BubbleSort();
            InsertionSort();
            QuickSort();
        }

        static void BubbleSort()
        {
            int[] myArray = { 9, 0, -4, 1, 7, 3, 6, 15, 2, 5 };
            Console.WriteLine("Bubble Sort - Unsorted: " + string.Join(",", myArray));
            BubbleSort bubbleSort = new BubbleSort();
            bubbleSort.Sort(myArray);
            Console.WriteLine("Sorted: " + string.Join(",", myArray));
        }

        static void InsertionSort()
        {
            Random randomNumber = new Random();
            int[] myArray = new int[10];
            for (int i = 0; i < myArray.Length; i++)
            {
                myArray[i] = randomNumber.Next(20);
            }
            Console.WriteLine("Insertion Sort - Unsorted Array: " + string.Join(", ", myArray));
            InsertionSort insertionSort = new InsertionSort();
            insertionSort.Sort(myArray);
            Console.WriteLine("Sorted Array: " + string.Join(", ", myArray));
        }

        static void QuickSort()
        {
            Random randomNumber = new Random();
            int[] myArray = new int[10]; // {9, 3, 5, 2, 6, 1, 8, 4, 14, 17, 3, 7, 3, 25};
            for (int i = 0; i < myArray.Length; i++)
            {
                myArray[i] = randomNumber.Next(20);
            }
            Console.WriteLine("Quick Sort - Unsorted Array: " + string.Join(", ", myArray));
            QuickSort quickSort = new QuickSort();
            quickSort.Sort(myArray);
            Console.WriteLine("Sorted Array: " + string.Join(", ", myArray));
        }
    }
}

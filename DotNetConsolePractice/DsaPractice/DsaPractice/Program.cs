using System;

namespace DsaPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BubbleSort();
            InsertionSort();
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
    }
}

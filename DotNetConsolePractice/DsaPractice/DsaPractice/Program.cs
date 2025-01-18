using System;

namespace DsaPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = {9, 0, -4, 1, 7, 3, 6, 15, 2, 5 };
            Console.WriteLine("Unsorted: " + string.Join(",", myArray));
            BubbleSort bubbleSort = new BubbleSort();
            bubbleSort.Sort(myArray);
            Console.WriteLine("Sorted: " + string.Join(",", myArray));
        }
    }
}

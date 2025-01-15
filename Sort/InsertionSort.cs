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
            InsertionSort insertionSort = new InsertionSort();
            insertionSort.Sort(myArray);
            Console.WriteLine("Sorted Array: " + string.Join(", ", myArray));
        }
    }

    public class InsertionSort
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

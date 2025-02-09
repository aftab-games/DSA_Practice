using System;

namespace DsaPractice
{
    internal static class Utils
    {
        public static void PrintArray(string message, int[] array)
        {
            Console.WriteLine(message + string.Join(", ", array));
        }
        public static int[] GenerateRandomArray(int length, int maxValue)
        {
            Random randomNumber = new Random();
            int[] myArray = new int[length];
            for (int i = 0; i < myArray.Length; i++)
            {
                myArray[i] = randomNumber.Next(maxValue);
            }
            return myArray;
        }

        public static void SwapArrayItems(int[] array, int index1, int index2)
        {
            int temp = array[index1];
            array[index1] = array[index2];
            array[index2] = temp;
        }
    }
}

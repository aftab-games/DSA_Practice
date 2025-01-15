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
            MergeSort mergeSort = new MergeSort();
            mergeSort.MergeAndSort(myArray);
            Console.WriteLine("Sorted Array: " + string.Join(", ", myArray));
        }
	}
	
	public class MergeSort
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
    }
}
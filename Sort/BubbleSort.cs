using System;

namespace Aftab.DSA.Sort
{
	public class Program
	{
		public static void Main(string[] args)
		{
			int[] itemsArray = {7, 4, 9, 3, 19, 1, 18, 7, 6, 5, 2, 23, 55, 64, 35, 33, 76};
			Console.WriteLine("Unsorted Array: "+string.Join(", ", itemsArray));
			BubbleSort bubbleSort = new BubbleSort();
			bubbleSort.Sort(itemsArray);
			Console.WriteLine("Sorted Array: "+string.Join(", ", itemsArray));
		}
	}
	
	public class BubbleSort
	{
	    void SwapItemsOfArray(int[] items, int index1, int index2)
        {
            int tempVal = items[index1];
            items[index1] = items[index2];
            items[index2] = tempVal;
	    }
	    
        public void Sort(int[] items, bool ascending = true)
        {
            int itemsCount = items.Length;
            bool isSorted = true;
      
            for(int i = 0; i < itemsCount; i++ )
            {
                isSorted = true;
                for(int j=0; j < itemsCount - 1 - i; j++ )
                {
                    if(ascending && items[j] > items[j+1])
                    {
                        SwapItemsOfArray(items, j, j+1);
                        isSorted = false;
                    }
                    else if(!ascending && items[j] < items[j+1])
                    {
                        SwapItemsOfArray(items, j, j+1);
                        isSorted = false;
                    }
                }
                if(isSorted) return;
            }
        }
	}
}
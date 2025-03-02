using System;
namespace DsaPractice
{
    internal class AArray
    {
        int[] items;
        int itemCount = 0;
        int length = 0;
        public AArray(int length)
        {
            items = new int[length];
            this. length = length;
        }

        public int GetLength() => length;
        public int GetItemCount() => itemCount;
        public void Insert(int item)
        {
            if(itemCount == length)
            {
                int[] tempItems = new int[length * 2];
                for(int i = 0; i < length; i++)
                {
                    tempItems[i] = items[i];
                }
                items = tempItems;
                length *= 2;
            }
            items[itemCount] = item;
            itemCount++;
        }

        public void PrintAArray()
        {
            for (int i = 0; i < itemCount; i++)
            {
                Console.WriteLine(items[i]);
            }
        }
    }
}

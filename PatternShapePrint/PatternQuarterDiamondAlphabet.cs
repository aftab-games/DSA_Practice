using System;

namespace Aftab.DSA.PatternPrint
{
	public class Program
	{
		public static void Main(string[] args)
		{
            int rows = 27;
            for (int row = 0; row < rows; row++)
            {
                for (int star = 0; star <= row; star++)
                {
                    int charVal = 64 + star;
                    Console.Write((char)charVal + " ");
                }
                Console.WriteLine();
            }
            /*
            //In C
            int rows = 27;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    printf("%c", j + 64);
                }
                printf("\n");
            }
            */
        }
    }
}
using System;

namespace Aftab.DSA.PatternPrint
{
	public class Program
	{
		public static void Main(string[] args)
		{
            int rows = 7;
            for (int row = 0; row < rows; row++)
            {
                for (int star = 0; star <= row; star++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }

            for (int row = rows - 1; row > 0; row--)
            {
                for (int star = 0; star < row; star++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }
	}
	
}
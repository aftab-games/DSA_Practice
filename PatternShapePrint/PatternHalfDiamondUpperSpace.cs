using System;

namespace Aftab.DSA.PatternPrint
{
	public class Program
	{
		public static void Main(string[] args)
		{
            int rows = 5;
            for (int row = 1; row <= rows; row++)
            {
                for (int space = 1; space <= rows - row; space++)
                {
                    Console.Write(" ");
                }
                for (int star = 1; star <= row; star++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }
	}
	
}
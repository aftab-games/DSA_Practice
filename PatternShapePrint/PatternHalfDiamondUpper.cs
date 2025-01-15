using System;

namespace Aftab.DSA.PatternPrint
{
	public class Program
	{
		public static void Main(string[] args)
		{
            int rows = 5;
            for (int row = 0; row < rows; row++)
            {
                for (int space = 0; space < rows - row - 1; space++)
                {
                    Console.Write(" ");
                }
                for (int star = 0; star < 2 * row + 1; star++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
	}
	
}
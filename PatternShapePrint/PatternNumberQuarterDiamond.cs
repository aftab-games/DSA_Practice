using System;

namespace Aftab.DSA.PatternPrint
{
	public class Program
	{
		public static void Main(string[] args)
		{
            int row = 5;
            row = int.Parse(Console.ReadLine()); // Console.Read();
            int printCount = 1;
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    //Console.Write("*"+" ");
                    Console.Write("{0}", printCount + " ");
                    printCount++;
                }
                Console.WriteLine();
            }
        }
	}
	
}
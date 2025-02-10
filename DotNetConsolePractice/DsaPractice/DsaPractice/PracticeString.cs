using System;

namespace DsaPractice
{
    internal class PracticeString
    {
        public static void Paractice()
        {
            string myString = "Hello Aftab!";
            Console.WriteLine("Initial String : "+myString);
            ReverseString(myString);
        }

        static void ReverseString(string myString)
        {
            string reversedString = string.Empty;
            int length = myString.Length;
            for (int i = length - 1; i >= 0; i--) reversedString += myString[i];
            Console.WriteLine("Reversed String: "+reversedString);
        }
    }
}

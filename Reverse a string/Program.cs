using System;

namespace Reverse_a_string
{
    class Program
    {
        static void Main(string[] args)
        { 
            Console.WriteLine("Enter a string");
            string input = Console.ReadLine();

            //Using two strings
            string output = string.Empty;
            for (int i = input.Length - 1; i >= 0; i--)
            {
                output += input[i];
            }

            Console.WriteLine(output);

            //Using two array's
            char[] sChars = input.ToCharArray();
            char[] myArr = new char[input.Length];
            for (int i = 0, j = sChars.Length - 1; i < sChars.Length; i++, j--)
            {
                myArr[i] = sChars[j];
            }
            Console.WriteLine(myArr);
        }
    }
}

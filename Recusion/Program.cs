using System;

namespace Recusion
{
    class Program
    {
        // calls itself one or more times until a specified condition is met at which time the
        // rest of each repetition is processed from the last one called to the first

        static int Print_Recursion_Values(int static_Val, int toPrint_Val)
        {
            if(toPrint_Val < 1)
            {
                return static_Val;
            }
            toPrint_Val--;
            Console.Write(static_Val);
            return Print_Recursion_Values(static_Val + 1, toPrint_Val);
        }
        static void Main(string[] args)
        {
            Console.Write("\n\n Recursion : Print the first n natural number :\n");
            Console.Write("\n");
            Console.Write(" How many numbers to print : ");
            int ctr = Convert.ToInt32(Console.ReadLine());

            Print_Recursion_Values(1, ctr);
        }
    }
}

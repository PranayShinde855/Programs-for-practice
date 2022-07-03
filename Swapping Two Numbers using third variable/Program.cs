using System;

namespace Swapping_Two_Numbers_using_third_variable
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number.");
            var num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter second number.");
            var num2 = Convert.ToInt32(Console.ReadLine());


            var var3 = 0;

            var3 = num1;
            num1 = num2;
            num2 = var3;

            Console.WriteLine("After swapping First number." +num1 );
            Console.WriteLine("After swapping Second number." + num2 );

        }
    }
}

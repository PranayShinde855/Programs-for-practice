using System;

namespace Swapping_Two_Numbers_without_using_third_variable
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number.");
            var num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter second number.");
            var num2 = Convert.ToInt32(Console.ReadLine());

            num1 = num1 * num2;
            num2 = num1/num2;
            num1 = num1 / num2;

            Console.WriteLine("After swapping First number." + num1);
            Console.WriteLine("After swapping Second number." + num2);
        }
    }
}

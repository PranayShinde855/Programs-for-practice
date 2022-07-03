using System;

namespace Armstrong_Number_Between_Two_Intervals
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, r, n, sum;
            Console.WriteLine("Enter two numbers");
            num1 = Convert.ToInt32(Console.ReadLine());
            num2 = Convert.ToInt32(Console.ReadLine());

            for (int i = num1; i <= num2; i++)
            {

                r = 0;
                sum = 0;
                n = i;
                while (n!=0)
                {
                    r = n % 10;
                    sum = sum + (r * r * r);
                    n = n / 10;
                }
                if (i == sum)
                    Console.WriteLine(i);
            }
        }
    }
}

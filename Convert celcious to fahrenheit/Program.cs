using System;

namespace Convert_celsius_to_fahrenheit
{
    class Program
    {
        static void Main(string[] args)
        {
            double c, f;

            Start:
            Console.WriteLine("To convert celsius to fahrenheit press 1");
            Console.WriteLine("To convert fahrenheit to celsius press 2");
            var ip = Convert.ToInt16(Console.ReadLine());

            if (ip == 1)
            {
                Console.WriteLine("Enter celsius");
                c = Convert.ToDouble(Console.ReadLine());

                f = (c * 9 / 5) + 32;

                Console.WriteLine(c + " celsius = " + f + " fahrenheit");
            }

            else if (ip == 2)
            {
                Console.WriteLine("Enter fahrenheit");
                f = Convert.ToDouble(Console.ReadLine());

                c = (f - 32) * 5/9 ;

                Console.WriteLine(f + " fahrenheit = " + c + " celsius");
            }
            else
            {
                Console.WriteLine("Please select valid option.");
                goto Start;
            }
        }
    }
}

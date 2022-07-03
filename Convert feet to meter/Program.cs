using System;

namespace Convert_feet_to_meter
{
    class Program
    {
        static void Main(string[] args)
        {
            double feet;
            double meter;

            Start:
            Console.WriteLine("To convert feet to meter press 1");
            Console.WriteLine("To convert meter to feet press 2");
            var ip = Convert.ToInt16(Console.ReadLine());

            if (ip == 1)
            {
                Console.WriteLine("Enter feet");
                feet = Convert.ToDouble(Console.ReadLine());

                meter = feet / 3.2808399;

                Console.WriteLine(feet + " feet = " + meter + " meter");
            }

            else if (ip == 2)
            {
                Console.WriteLine("Enter meter");
                meter = Convert.ToDouble(Console.ReadLine());

                feet = meter * 3.2808399;

                Console.WriteLine(meter + " meter = " + feet + " feet");
            }
            else
            {
                Console.WriteLine("Please select valid option.");
                goto Start;
            }
        }
    }
}

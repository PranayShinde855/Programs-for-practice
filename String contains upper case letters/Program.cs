using System;

namespace String_contains_upper_case_characterss
{
    class Program
    {
        public static bool StringContainsUpperCase(string str)
        {
            bool result = false;
            for (int i = 0; i < str.Length; i++)
            {
                if ((str[i] >= 65) && str[i] <= 90)
                    result = true;

                // Upper case & Lower case characterss can be check grom on function 
                //if ((str[i] >= 65) && str[i] <= 90 || (str[i] >= 97) && str[i] <= 122))
            }
            return result;
        }

        public static bool StringContainsLowerCase(string str)
        {
            bool result = false;
            for (int i = 0; i < str.Length; i++)
            {
                if ((str[i] >= 97) && str[i] <= 122)
                    result = true;
            }
            return result;
        }

        static void Main(string[] args)
        {
            start:
            Console.WriteLine(" To check for upper case character press u. " +
                "\n To check for lower case character press l. \n To end the program press e. ");
            string input = Console.ReadLine();
            if(input == "u")
            {
                goto upper;
            }
            else if(input == "l")
            {
                goto lower;
            }
            else if( input == "e")
            {
                return;
            }
            else
            {
                Console.WriteLine("Please select valid option. \n");
                goto start;
            }


            //For upper case
            upper:
            Console.WriteLine("Enter string");
            string str = Console.ReadLine();
            bool outpput = StringContainsUpperCase(str);
            if(outpput == true)
            {
                Console.WriteLine("The string " + str + " contains upper case characterss. \n");
            }
            else
            {
                Console.WriteLine("The string " + str + " does not contains upper case characterss. \n");
            }
            goto start;

            //For lower case
            lower:
            Console.WriteLine("Enter string");
            string str1 = Console.ReadLine();
            bool outpput1 = StringContainsUpperCase(str1);
            if (outpput1 == true)
            {
                Console.WriteLine("The string " + str1 + " contains upper case characterss. \n");
            }
            else
            {
                Console.WriteLine("The string " + str1 + " does not contains upper case characterss. \n");
            }
            goto start;
        }
    }
}

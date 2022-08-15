using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    internal class Reverse_Number

    {
        public static void show_reverse()
        {
            int reverse = 0;
            Console.WriteLine("Enter Number to Reverse = ");
            int number = Convert.ToInt32(Console.ReadLine());
            while (number != 0)
            {
                int remainder = number % 10;
                reverse = reverse * 10 + remainder;
                number = number / 10;
            }
            Console.WriteLine("The reverse of the given number is: " + reverse);
        }
    }
}

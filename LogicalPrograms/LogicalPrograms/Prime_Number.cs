using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    internal class Prime_Number
    {
        public static void show_prime()
        {
            int i, m = 0, flag = 0;
            Console.WriteLine("Enter the Number = ");
            int n = int.Parse(Console.ReadLine());   
            m = n / 2;
            if (n == 0 || n == 1)
            {
                Console.WriteLine(n + " is not prime number");
            }
            else
            {
                for (i = 2; i <= m; i++)
                {
                    if (n % i == 0)
                    {
                        Console.WriteLine(n + " is not prime number");
                        flag = 1;
                        break;
                    }
                }
                if (flag == 0) { Console.WriteLine(n + " is prime number"); }

            }
        }
    }
}

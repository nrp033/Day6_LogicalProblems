using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    internal class Perfect_Number
    {
        public static void show_perfect()
        {

            long sum = 0;

            Console.WriteLine("Enter the number: ");
            long n=Convert.ToInt64(Console.ReadLine());
            int i = 1;
            
            while (i <= n / 2)
            {
                if (n % i == 0)
                {
                    
                    sum = sum + i;
                }  
                 
                i++;
            } 
              
            if (sum == n)
            {
             
                Console.WriteLine(n + " is a perfect number.");
            }  
            else
               
                Console.WriteLine(n + " is not a perfect number.");

        }
    }
}

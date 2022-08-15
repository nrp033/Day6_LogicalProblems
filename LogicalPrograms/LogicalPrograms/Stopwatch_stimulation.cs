using System;
using System.Diagnostics;
using System.Threading;
namespace LogicalPrograms
{
    class Stopwatch_Stimulation
    {
        public static void show_stopwatch()
        {
            Stopwatch stopwatch = new Stopwatch();
            // Begin timing
            stopwatch.Start();
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("HI");
            }
            // Stop timing
            stopwatch.Stop();
            Console.WriteLine("Time Elapsed : {0}",stopwatch.Elapsed);
            Console.ReadLine();
        }

    }
}
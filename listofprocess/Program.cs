using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;

namespace listofprocess
{
    class Program
    {
      
        static int count = 0;
        static void Main()
        {

            var stopwatch = Stopwatch.StartNew();
            Thread.Sleep(0);
            stopwatch.Stop();
            Console.WriteLine("waiting ...");
            //Console.WriteLine(DateTime.Now.ToLongTimeString());

            stopwatch = Stopwatch.StartNew();
            Thread.Sleep(5000);
            stopwatch.Stop();
            Console.WriteLine(stopwatch.ElapsedMilliseconds);
            Console.WriteLine(DateTime.Now.ToLongTimeString());

            stopwatch = Stopwatch.StartNew();
            System.Threading.Thread.Sleep(1000);
            stopwatch.Stop();
            Console.WriteLine(stopwatch.ElapsedMilliseconds);

            //
            // Bonus: shows SpinWait method.
            //
            stopwatch = Stopwatch.StartNew();
            Thread.SpinWait(100000 * 10000);
            stopwatch.Stop();
            Console.WriteLine(stopwatch.ElapsedMilliseconds);
            Console.ReadKey();
        }
       
    }
}

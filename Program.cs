using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Log4Net_1
{
    class Program
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        static void Main(string[] args)
        {

            var watch = System.Diagnostics.Stopwatch.StartNew();
            int number;


            //1.Gets a number as an input
            Console.WriteLine("enter a number");
            number = Int32.Parse(Console.ReadLine());

            //2.Runs in a loop until the amount of iterations = input number:
            for (int i = 0; i < number; i++) ;

            watch.Stop();
            var elapsedMs = watch.ElapsedMilliseconds;
            //3.Prints out the amount of time it took to run the loop:
            Console.WriteLine($"Execution Time: {elapsedMs} ms");

            //4.Creates a log file:
            log.Info($"Input: {number} - Time: {elapsedMs} ms");
        }
    }
}

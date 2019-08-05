using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Threading;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Fibonacci number";
            var width = Console.WindowWidth;
            string text = "Find the n - th Fibonacci number";
            var padding = width / 2 + text.Length / 2;
            Console.WriteLine("{0," + padding + "}", text + '\n');
            Stopwatch stopWatch = new Stopwatch();
            Console.WriteLine("Enter integer values ​​to determine the order of the Fibonacci number using recursion: ");
            int.TryParse(Console.ReadLine(), out int num);
            stopWatch.Start();
            //int temp = fib(num);
            int temp = fib_n(num);
            Console.WriteLine("Hotfix branch");
            stopWatch.Stop();
            TimeSpan ts = stopWatch.Elapsed;
            Console.WriteLine(string.Format("Fibonacci number of order {0} = {1}" + '\n' + "Elapsed time {2:00}:{3:00}:{4:00}.{5:00}", num,temp, ts.Hours, ts.Minutes, ts.Seconds,
            ts.Milliseconds / 10));
            Console.Read();
        }

        static int fib(int n)
        {
            if (n < 2 ) return n;
            return fib(n - 1) + fib(n - 2);
        }

       static int fib_n(int n)
        {
            //F(n)
            int x = 1;
            //F(n-1)
            int y = 0;
            for (int i = 0; i < n; i++)
            {
                x += y;
                y = x - y;
            }
            return y;
        }

    }   
}

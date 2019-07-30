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
            Console.WriteLine("{0," + padding + "}", text);
            Console.WriteLine();
            Console.WriteLine("Enter integer values ​​to determine the order of the Fibonacci number: ");
            int.TryParse(Console.ReadLine(), out int num);
            int temp = fib(num);
            Console.WriteLine(temp);
            Console.Read();
        }

        static int fib(int n)
        {
            if (n < 2 ) return n;
            return fib(n - 1) + fib(n - 2);
        }

    }   
}

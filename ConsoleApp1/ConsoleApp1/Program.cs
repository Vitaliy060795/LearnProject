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
            while (true)
            {
                MainMethod();
            }
        }

        static void MainMethod()
        {
            Stopwatch stopWatch = new Stopwatch();
            Console.WriteLine("Select a function from the list and enter the corresponding number:");
            Console.WriteLine("1 - Find the Fibonacci number with recursion");
            Console.WriteLine("2 - Find the Fibonacci number without recursion");
            Console.WriteLine("3 - Creating a graph using recursion");
            if (int.TryParse(Console.ReadLine(), out int num) && num > 0 && num < 4)
            {
                if (num == 1 || num == 2)
                {
                    int a = 0;
                    Console.WriteLine("Enter the number n");
                    if (int.TryParse(Console.ReadLine(), out int num2))
                    {
                        if (num == 1)
                        {
                            stopWatch.Start();
                            a = fib(num2);
                            stopWatch.Stop();

                        }
                        else if (num == 2)
                        {
                            stopWatch.Start();
                            a = fib_n(num2);
                            stopWatch.Stop();
                        }
                        Console.WriteLine(string.Format("Fibonacci number of order {0} = {1}" + '\n' + "Time taken: {2} ms", num2, a, stopWatch.Elapsed.TotalMilliseconds));
                    }
                }
                else if (num == 3)
                {
                    Console.WriteLine("Enter chart depth");
                    int.TryParse(Console.ReadLine(), out int deep);
                    Console.WriteLine("Enter the number of children");
                    int.TryParse(Console.ReadLine(), out int children);

                    Class1 temp = new Class1();
                    temp.CreateGraph(deep, children);
                }
                else
                {
                    Console.WriteLine("You entered an invalid value, try again");
                }
            }
            else
            {
                Console.WriteLine("You entered an invalid value, try again");
            }
    }
       
        static int fib(int n)
        {
            if (n < 2 ) return n;
            return fib(n - 1) + fib(n - 2);
        }

       static int fib_n(int n)
        {
            int x = 1;
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

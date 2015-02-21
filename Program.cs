using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;


namespace ConsoleApplication1
{
    class Program
    {
        public static Stopwatch watch = new Stopwatch();

        static void Main(string[] args)
        {
            long deger = 0;
            Console.Write("Kacinci Fibonacciyi Bulayim : ");
            deger = Convert.ToInt64(Console.ReadLine());

         
            watch.Start();
            Console.WriteLine("{0} . Fibonacci: {1}", deger,loop(deger));
            watch.Stop();

            Console.WriteLine("Gecen sure: {0} ", watch.Elapsed.ToString());
            Console.ReadLine();
        }
        public static long loop(long girdi)
        {
            long fib1 = 1;
            long fib2 = 1;
            long gecici = 0;
            while (2 < girdi)
            {
                gecici = fib1 + fib2;
                fib1 = fib2;
                fib2 = gecici;
                girdi = girdi - 1;
            }
            return gecici;
        }
       
    }
}

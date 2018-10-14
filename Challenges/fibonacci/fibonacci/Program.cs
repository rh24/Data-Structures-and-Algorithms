using System;

namespace Fibonacci
{
    public class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 30; i++)
            {
                Console.WriteLine(IterativeFibonacci(i));
            }
            Console.ReadLine();
        }

        public static int IterativeFibonacci(int n)
        {
            // starting numbers
            int x = 0;
            int y = 1;
            int temp;

            for (int i = 0; i < n; i++)
            {
                temp = x;
                x = y;
                y = temp + y;
            }

            return x;
        }
    }
}

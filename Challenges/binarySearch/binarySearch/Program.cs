using System;

namespace binarySearch
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        static int BinarySearch(int[] input, int target)
        {
            int start = 0;
            int end = input.Length - 1;

            while (start <= end)
            {
                int middle = end / 2;

                if (middle == target) return middle;
                if (middle < target) end = middle - 1;
                else start = middle + 1;
            }

            return -1;
        }
    }
}

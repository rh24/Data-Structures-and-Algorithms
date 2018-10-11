using System;

namespace binarySearch
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hello");
            Console.WriteLine("The index of 3 is {0}", BinarySearch(new int[] { 1, 3, 6, 7 }, 3).ToString());
            Console.WriteLine("The index of 9 is {0}", BinarySearch(new int[] { 1, 3, 6, 7, 8, 9 }, 9).ToString());
            Console.ReadLine();
        }

        public static int BinarySearch(int[] input, int target)
        {
            int start = 0;
            int end = input.Length - 1;

            while (start <= end)
            {
                int middle = (start + end) / 2;

                if (input[middle] == target) return middle;
                if (target < input[middle]) end = middle - 1;
                else start = middle + 1;
            }

            return -1;
        }
    }
}

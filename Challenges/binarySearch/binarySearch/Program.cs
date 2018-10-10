using System;

namespace binarySearch
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hello");
            Console.WriteLine(BinarySearch(new int[] { 1, 3, 6, 7 }, 3).ToString());
            Console.ReadLine();
        }

        public static int BinarySearch(int[] input, int target)
        {
            int start = 0;
            int end = input.Length - 1;

            while (start <= end)
            {
                int middle;
                if (end % 2 != 0) middle = end / 2;
                else middle = (end / 2) + 1;

                if (input[middle] == target) return middle;
                if (target < input[middle]) end = middle - 1;
                else start = middle + 1;
            }

            return -1;
        }
    }
}

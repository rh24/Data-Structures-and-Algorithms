using System;

namespace arrayShift
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Old array: [{0}]", string.Join(", ", new int[] { 1, 2, 4, 5 }));
            Console.WriteLine("New array: [{0}]", string.Join(", ", ArrayShift(new int[] { 1, 2, 4, 5 }, 3)));
            Console.WriteLine("Old array: [{0}]", string.Join(", ", new int[] { 1, 2, 4, 5, 6}));
            Console.WriteLine("New array: [{0}]", string.Join(", ", ArrayShift(new int[] { 1, 2, 4, 5, 6 }, 3)));
        }

        public static int[] ArrayShift(int[] input, int val)
        {
            int[] newArr = new int[input.Length + 1];
            int middle = newArr.Length / 2;

            for (int i = 0; i < newArr.Length; i++)
            {
                if (i < middle) newArr[i] = input[i];
                else if (i == middle) newArr[i] = val;
                else newArr[i] = input[i - 1];
            }

            return newArr;
        }
    }
}

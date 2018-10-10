using System;

namespace arrayShift
{
    public class Program
    {
        static void Main(string[] args)
        {
            ArrayShift(new int[] {1, 2, 4, 5}, 3);
        }

        public static int[] ArrayShift(int[] input, int val)
        {
            int[] newArr = new int[input.Length + 1];
            int middle = input.Length % 2 == 0 ? newArr.Length / 2 : (newArr.Length / 2) + 1;

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

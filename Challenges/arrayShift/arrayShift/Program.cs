using System;

namespace arrayShift
{
    class Program
    {
        static void Main(string[] args)
        {
            //ArrayShift();
        }

        static int[] ArrayShift(int[] input, int val)
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

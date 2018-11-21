using System;

namespace Merge_Sort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 4, 10, 1, 70, 55, 500, 8, 33, 254, 0, 0, 18 };
            MergeSort(arr);
        }

        /// <summary>
        /// This method recursively sorts an input array through a divide and conquer sorting algorithm called "Merge Sort."
        /// </summary>
        /// <param name="arr">Input array</param>
        public static void MergeSort(int[] arr)
        {
            if (arr.Length > 1)
            {
                int[] left = new int[arr.Length / 2];
                Array.Copy(arr, 0, left, 0, arr.Length / 2);

                int[] right = new int[arr.Length - left.Length];
                Array.Copy(arr, arr.Length / 2, right, 0, right.Length);

                MergeSort(left);
                MergeSort(right);
                Merge(left, right, arr);
            }

            Console.WriteLine($"[{string.Join(", ", arr)}]");
        }

        /// <summary>
        /// This method merges all the values from the arrays that have been broken down into their smallest parts.
        /// </summary>
        /// <param name="">Left side of original array</param>
        /// <param name="">Right side of original array</param>
        /// <param name="">Original array</param>
        /// <returns></returns>
        public static int[] Merge(int[] leftArr, int[] rightArr, int[] originalArr)
        {
            // Left pointer
            int i = 0;
            // Right pointer
            int j = 0;
            // Ending array pointer
            int k = 0;

            Console.WriteLine($"Left: [{string.Join(", ", leftArr)}]");
            Console.WriteLine($"Right: [{string.Join(", ", rightArr)}]");
            Console.WriteLine($"Original: [{string.Join(", ", originalArr)}]");

            while (i < leftArr.Length && j < rightArr.Length)
            {
                if (leftArr[i] <= rightArr[j])
                {
                    originalArr[k] = leftArr[i];
                    i++;
                }
                else
                {
                    originalArr[k] = rightArr[j];
                    j++;
                }

                k++;
            }

            if (i == leftArr.Length) Array.Copy(rightArr, j, originalArr, k, rightArr.Length - j);
            if (j == rightArr.Length) Array.Copy(leftArr, i, originalArr, k, leftArr.Length - i);

            return originalArr;
        }
    }
}

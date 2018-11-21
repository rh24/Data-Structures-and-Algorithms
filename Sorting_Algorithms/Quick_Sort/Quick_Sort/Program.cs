using System;

namespace Quick_Sort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 40, 21, 3, 10, 1, 5, 0, 70, 15, 3, 961, 450, 200, 154, 11, 1, 310 };
            int[] arr2 = new int[] { 0, 1, 2, 3, 4, 5 };
            int[] arr3 = new int[] { 0, 20, 35 };
            QuickSort(arr, 0, arr.Length - 1);
        }

        /// <summary>
        /// Recursively sort an array using the Quick Sort algorithm. Setting left equal to the 0 index and right equal to the last index of array ensures that the entire input array will be sorted, not just a portion of it.
        /// </summary>
        /// <param name="arr">Input array</param>
        /// <param name="left">Starting index to sort</param>
        /// <param name="right">Last index of array to sort until</param>
        public static void QuickSort(int[] arr, int left, int right)
        {
            if (left < right)
            {
                // Set the partition for sorting the array
                int position = Partition(arr, left, right);
                // Sort left of partition
                QuickSort(arr, left, position - 1);
                // Sort right of partition
                QuickSort(arr, position + 1, right);
            }
        }

        /// <summary>
        /// This method sets the partition point from which the array gets sorted.
        /// </summary>
        /// <param name="arr">input array</param>
        /// <param name="left">lower index</param>
        /// <param name="right">upper index</param>
        /// <returns></returns>
        public static int Partition(int[] arr, int left, int right)
        {
            // Set the pivot point
            int pivot = arr[right];
            // Index of the lower value
            int low = left;

            for (int i = left; i < right; i++)
            {
                // Sample step through:
                // [0, 20, 35]
                // first iteration:
                // i = 0
                // pivot = 35
                // arr[0] = 0
                // low = 0
                // Swap(arr, 0, 0) // Value at index arr[0] gets replaced with same number because 0 < 35
                // increment low // low = 1
                // second iteration:
                // i = 1
                // pivot = 35
                // arr[1] = 20
                // low = 1
                // Swap(arr, 1, 1) // Value at index arr[1] gets replaced with same number because 20 < 35
                // increment low // low = 2 gets returned to int position variable as Partition finishes running, since last Swap frame is popped off the stack
                if (arr[i] <= pivot)
                {
                    Swap(arr, i, low);
                    low++;
                }
            }

            Swap(arr, right, low);

            Console.WriteLine(string.Join(", ", arr));

            return low;
        }

        /// <summary>
        /// This method swaps the values of the array at i with the value of array at low. 
        /// </summary>
        /// <param name="arr">Input array</param>
        /// <param name="i">Index of array at i or right, determined by function call within Partition method</param>
        /// <param name="low">Index of array at low, determined by function call within Partition method</param>
        public static void Swap(int[] arr, int i, int low)
        {
            int temp = arr[i];
            arr[i] = arr[low];
            arr[low] = temp;
        }
    }
}

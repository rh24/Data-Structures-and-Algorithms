using System;

namespace Insertion_Sort
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] unsorted = new int[] { 2, 8, 5, 3, 1 };

            // Print original v. insertion sorted array:
            Console.WriteLine("Original unsorted array:" + Environment.NewLine + string.Join(", ", unsorted));
            Console.WriteLine("Insertion sorted array:" + Environment.NewLine + string.Join(", ", InsertionSort(unsorted)));
        }

        /// <summary>
        /// Method sorts an unsorted array using the Insertion Sort algorithm.
        /// </summary>
        /// <param name="myArr">Unsorted array</param>
        /// <returns>Sorted array in ascending order</returns>
        public static int[] InsertionSort(int[] myArr)
        {
            for (int i = 1; i < myArr.Length; i++)
            {
                int temp = myArr[i];
                int j = i - 1;

                while (j >= 0 && temp < myArr[j])
                {
                    myArr[j + 1] = myArr[j];
                    myArr[j] = temp;
                    j--;
                }

                // Comment in to see line by line sorting after each loop:
                // Console.WriteLine(string.Join(", ", myArr));
            }

            return myArr;
        }
    }
}

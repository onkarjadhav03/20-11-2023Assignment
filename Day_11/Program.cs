using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_11
{
    internal class Program
    {
        public static void QuickSort(int[] array)
        {
            QuickSort(array, 0, array.Length - 1);
        }
        private static void QuickSort(int[] array, int left, int right)
        {
            if (left < right)
            {
                int pivotIndex = Partition(array, left, right);
                QuickSort(array, left, pivotIndex - 1);
                QuickSort(array, pivotIndex + 1, right);
            }
        }
        private static int Partition(int[] array, int left, int right)
        {
            int pivot = array[right];
            int i = left - 1;
            for (int j = left; j < right; j++)
            {
                if (array[j] < pivot)
                {
                    i++;
                    Swap(array, i, j);
                }
            }
            Swap(array, i + 1, right);
            return i + 1;
        }
        private static void Swap(int[] array, int i, int j)
        {
            int temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }
        public static void Print(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i] + " ");
            }
            Console.WriteLine("\n");
        }
        static void Main(string[] args)
        {
          // int[] array = { 9, -3, 5, 2, 6, 8, -6, 1, 3 };
            int[] array = { 9, 6, 8, -6, 1 };
            Console.WriteLine("Original Array");
            Print(array);
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            QuickSort(array);
            stopwatch.Stop();
            Console.WriteLine("after quicksort");
            Print(array);
            Console.WriteLine($"Arraysize {array.Length} time taken {stopwatch.Elapsed.TotalMilliseconds} milliseconds");
            Console.ReadKey();
        }
    }
}

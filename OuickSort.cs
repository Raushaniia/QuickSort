using System;

namespace QuickSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = {1, 4, 2, 7, 8, 3, 9, 5 };
            QuickSort(array, 0, array.Length-1);
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
            Console.ReadLine();
        }
        public static void QuickSort(int [] array, int start, int end) {
            if (start > end)
                return;
            int marker = Partition(array, start, end);
            QuickSort(array, marker + 1, end);
            QuickSort(array, start, marker - 1);
        }
        public static int Partition(int[] array, int start, int end) {
            int i = start;
            int j = end;
            int m = array[start];
            while (i<j) {
                while (array[i] < m)
                {
                    i++;
                }
                while (array[j] > m)
                {
                    j--;
                }
                if (i < j)
                {
                    int temp = array[j];
                    array[j] = array[i];
                    array[i] = temp;
                }
            }
            return i;
        }
    }
}

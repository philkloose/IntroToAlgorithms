using System;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] unsortedArray = {31,41,59,26,41,58};

            //int[] unsortedArray = CreateUnsortedArray(100000);

            InsertionSort(unsortedArray);
        }

        private static int[] InsertionSort(int[] a) {

            for (int j = 1; j <= a.Length - 1; j++)
            {
                PrintArray(a);
                int key = a[j];
                int i = j - 1;
                while (i >= 0 && a[i] > key) {
                    a[i + 1] = a[i];
                    i = i - 1;
                }
                a[i + 1] = key;
            }

            PrintArray(a);

            return a;
        }

        private static int[] CreateUnsortedArray(int length)
        {

            int[] array = new int[length];
            Random r = new Random();
            for (int i = 0; i < array.Length; i++) {
                array[i] = r.Next(Int32.MinValue, Int32.MaxValue);
            }

            return array;
        }

        private static void PrintArray (int[] a) {
            for (int i = 0; i < a.Length; i++) {
                if (i != a.Length - 1)
                {
                    Console.Write(a[i] + ", ");
                } else {
                    Console.Write(a[i]);
                }
            }
            Console.WriteLine();
        }
    }
}

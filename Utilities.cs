using System;
public class Utilities {

    public static int[] CreateUnsortedArray (int length, int min, int max) {

        int[] array = new int[length];
        Random r = new Random();
        for (int i = 0; i < array.Length; i++) {
            array[i] = r.Next(min, max);
        }

        return array;
    }

    public static int[] CreateUnsortedArray (int length) {

        int[] array = new int[length];
        Random r = new Random();
        for (int i = 0; i < array.Length; i++) {
            array[i] = r.Next(Int32.MinValue, Int32.MaxValue);
        }

        return array;
    }

    public static void PrintArray (int[] a) {
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
    
    public static string ReturnArrayAsString (int[] a) {
        string s = "[";

        for (int i = 0; i < a.Length; i++) {
            if (i != a.Length - 1) {
                s += a[i] + ", ";
            } else {
                s += a[i];
            }
        }

        return s + "]";
    }
}
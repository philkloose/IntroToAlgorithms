using System;

public class Chapter2 {
    public static int[] InsertionSort(int[] a) {

        for (int j = 1; j <= a.Length - 1; j++)
        {
            //Utilities.PrintArray(a);
            int key = a[j];
            int i = j - 1;
            while (i >= 0 && a[i] > key) {
                a[i + 1] = a[i];
                i = i - 1;
            }
            a[i + 1] = key;
        }

        //Utilities.PrintArray(a);

        return a;
    }

    // Exercise 2.1-3
    public static int LinearSearch(int[] a, int v) {
        
        for (int i = 0; i < a.Length; i++) {
            if (a[i] == v) {
                return i;
            }
        }
        
        return 0;
    }

    public static int[] BinaryAdd(int[] a, int[] b) {
        int[] c = new int[a.Length + 1];
        int carry = 0;

        for (int i = a.Length; i > 0; i--) {
            int digit = a[i-1] + b[i-1] + carry;

            c[i] = digit % 2;
            if (digit < 2) {
                carry = 0;
            } else if (digit >= 2) {
                carry = 1;
            }
        }
        if (carry == 1) {
            c[0] = 1;
        }

        return c;
    }

    public static void Exercise2_1_1() {
        int[] unsortedArray = {31,41,59,26,41,58};

        Utilities.PrintArray(InsertionSort(unsortedArray));
    }
    public static void Exercise2_1_3() {
        int[] unsortedArray = {31,41,59,26,41,58};

        Console.WriteLine(LinearSearch(unsortedArray, 59));
    }

    public static void Exercise2_1_4() {
        
        int[] operand1 = {1,1,0,0}; // 12
        int[] operand2 = {1,0,1,0}; // 10

        Utilities.PrintArray(BinaryAdd(operand1, operand2));  // 22     
    }
}
using System;

public class Chapter2 {
    public static int[] InsertionSort(int[] a) {


        for (int j = 2; j <= a.Length; j++)
        {
            int key = a[(j - 1)];
            int i = (j - 1) - 1;
            while (i >= 0 && a[i] > key) {
                a[i + 1] = a[i];
                i--;
            }
            a[i + 1] = key;
        }

        return a;
    }
    
    public static int[] SelectionSort(int[] a) {
        
        for (int j = 0; j < a.Length - 1; j++) {
            Utilities.PrintArray(a);
            int key = a[j];
            int lowPos = j;
            for (int i = j + 1; i < a.Length; i++) {
                if (a[i] < a[j] && a[i] < a[lowPos]) {
                    lowPos = i;
                }
            }
            a[j] = a[lowPos];
            a[lowPos] = key;
        }

        return a;
    }

    public static int[] Merge(int[] a, int p, int q, int r) {
        // a = array
        // p = first element index
        // q = last element of first half of array 'a'
        // r = last element index

        int n1 = q - p + 1; // length of left half array
        int n2 = r - q; // length of right half array
        int[] L = new int [n1 + 1];
        int[] R = new int [n2 + 1];
        int i;
        int j;
        for (i = 1; i <= n1; i++) {
            L[i - 1] = a[p + (i - 1) - 1];
        }
        for (j = 1; j <= n2; j++) {
            R[j - 1] = a[q + (j - 1)];
        }
        L[n1] = Int32.MaxValue;
        R[n2] = Int32.MaxValue;
        i = 1;
        j = 1;
        for (int k = p; k <= r; k++) {
            if (L[i - 1] <= R[j - 1]) {
                a[k - 1] = L[i - 1];
                i++;
            } else {
                a[k - 1] = R[j - 1];
                j++;
            }
        }

        return a;
    }

    public static int[] MergeSort(int[] a, int p, int r) {
        // a = array
        // p = first element index
        // r = last element index

        if (p < r) {
            int q = ((p + r) / 2); // last element of first half of array 'a'
            MergeSort(a, p, q);
            MergeSort(a, q + 1, r);
            Merge(a, p, q, r);
        }

        return a;
    }

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

    public static void Exercise2_2_2() {

        int[] unsortedArray = Utilities.CreateUnsortedArray(10);

        Utilities.PrintArray(SelectionSort(unsortedArray));
    }

    public static void Exercise2_3_1() {

        int[] unsortedArray = Utilities.CreateUnsortedArray(10);

        Utilities.PrintArray(unsortedArray);
        Utilities.PrintArray(MergeSort(unsortedArray, 1, unsortedArray.Length));
    }
}
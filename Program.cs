using System;
using System.Diagnostics;
class Program
{
    delegate int[] ArrMethods(int[] arr);

    static int[] getEvenNums(int[] arr)
    {
        int[] evenNums = new int[arr.Length];
        int j = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] % 2 == 0)
            {
                evenNums[j] = arr[i];
                j++;
            }
        }
        return evenNums;
    }

    static int[] getOddNums(int[] arr)
    {
        int[] oddNums = new int[arr.Length];
        int j = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] % 2 != 0)
            {
                oddNums[j] = arr[i];
                j++;
            }
        }
        return oddNums;
    }

    static bool isPrime(int num)
    {
        if (num <= 1)
        {
            return false;
        }
        for (int i = 2; i <= num / 2; i++)
        {
            if (num % i == 0)
            {
                return false;
            }
        }
        return true;
    }

    static int[] getPrimeNums(int[] arr)
    {
        int[] primeNums = new int[arr.Length];
        int j = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (isPrime(arr[i]))
            {
                primeNums[j] = arr[i];
                j++;
            }
        }
        return primeNums;
    }

    static bool isFibonachi(int num)
    {
        int a = 0;
        int b = 1;
        while (a < num)
        {
            int temp = a;
            a = b;
            b = temp + b;
        }
        return a == num;
    }

    static int[] getFibonachiNums(int[] arr)
    {
        int[] fibonachiNums = new int[arr.Length];
        int j = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (isFibonachi(arr[i]))
            {
                fibonachiNums[j] = arr[i];
                j++;
            }
        }
        return fibonachiNums;
    }

    static void printArray(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] != 0)
            {
                Console.Write(arr[i] + " ");
            }
        }
    }

    static void Main()
    {
        ArrMethods[] arrMethods = new ArrMethods[4];
        arrMethods[0] = getEvenNums;
        arrMethods[1] = getOddNums;
        arrMethods[2] = getPrimeNums;
        arrMethods[3] = getFibonachiNums;

        int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        for (int i = 0; i < arrMethods.Length; i++)
        {
            Console.Write("Array of ");
            switch (i)
            {
                case 0:
                    Console.Write("even numbers: ");
                    break;
                case 1:
                    Console.Write("odd numbers: ");
                    break;
                case 2:
                    Console.Write("prime numbers: ");
                    break;
                case 3:
                    Console.Write("fibonachi numbers: ");
                    break;
            }
            printArray(arrMethods[i](arr));
            Console.WriteLine();
        }
    }
}

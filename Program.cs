using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Runtime.Intrinsics.X86;

internal class Program
{
    /// <summary>
    /// calculates sum of the array
    /// </summary>
    /// <param name="arr">input array </param>
    /// <returns>sum of the elements of the array</returns>
    static int sumMultiDiemensional(int[,] arr)
    {
        //Write a program that takes a 2D array of integers as input and
        //calculates the sum of all the elements in the array.
        //Display the sum as the output.

        int sum = 0;

        for (int row = 0; row < arr.GetLength(0); row++)
        {
            for (int column = 0; column < arr.GetLength(1); column++)
            {
                //Console.Write(arr[row, column] + " ");

                sum += arr[row, column];
            }
        }
        return sum;
    }

    static int sumArray(int[] num)
    {
        int sum = 0;
        for (int i = 0; i < num.Length; i++)
        {
            sum += num[i];

        }
        return sum;
    }

    static int avgArray(int[] num)
    {
        int sum = 0;
        int avg = 0;
        for (int i = 0; i < num.Length; i++)
        {
            sum += num[i];
            avg = sum / num.Length;
        }
        return avg;
    }

    static int minArray(int[] num)
    {
        int min = 0;
        for (int i = 0; i < num.Length; i++)
        {

            if (num[i] < min)
                min = num[i];
        }
        return min;
    }

    public static int maxArray(int[] num)
    {
        int max = 0;
        for (int i = 0; i < num.Length; i++)
        {
            if (num[i] > max)
            {
                max = num[i];
            }
        }
        return max;
    }

    public static int countArrayEven(int[] num)
    {
        int countEven = 0;
        int countOdd = 0;

        for (int i = 0; i < num.Length; i++)
        {
            if ((int.Parse(num[i].ToString()) % 2) == 0)
                countEven++;
            else
                countOdd++;
        }
        return countEven;
    }

    public static int countArrayOdd(int[] num)
    {
        int countEven = 0;
        int countOdd = 0;

        for (int i = 0; i < num.Length; i++)
        {
            if ((int.Parse(num[i].ToString()) % 2) == 0)
                countEven++;
            else
                countOdd++;
        }
        return countOdd;
    }

    //public static int secondLargest(int[] num)
    //{
    //    int second = 0;

    //}

    public static int removeDuplicate(int[] num)
    {
        var sList = new ArrayList();

        for (int i = 0; i < num.Length; i++)
        {
            if (sList.Contains(num[i]) == false)
            {
                sList.Add(num[i]);
            }
        }

        var sNew = sList.ToArray();

        for (int i = 0; i < sNew.Length; i++)
        {
            Console.Write(sNew[i]);
        }
        return num.Length;
    }

    static void Main(string[] args)
    {

        //Console.WriteLine("enter the array size:");
        //int n = int.Parse(Console.ReadLine());
        //int[] arr = new int[n];

        //Console.WriteLine("enter the elements:");
        //for (int row = 0; row < arr.Length ; row++)
        //{
        //    arr[row] = int.Parse(Console.ReadLine());
        //}

        //Console.WriteLine("the sum is:" + sumArray(arr)); //15
        //Console.WriteLine("the avg is:" + avgArray(arr)); //3

        //Console.WriteLine("the max is :" + maxArray(arr)); //5
        //Console.WriteLine("the min is :" + minArray(arr)); //1

        //Console.WriteLine("count for even :" + countArrayEven(arr));
        //Console.WriteLine("count for odd :" + countArrayOdd(arr));

        ////Console.WriteLine("second largest is :" + secondLargest(arr)); //4
        //Console.WriteLine("remove duplicate :" + removeDuplicate(arr)); //0
        //------------------------------------------------------------------
        //multidimensional

        //int totalRows = 2;
        //int totalCols = 3;
        //int[,] numbers = new int[totalRows, totalCols];
        //numbers[0, 0] = 30;
        //numbers[0, 1] = 35;
        //numbers[0, 2] = 40;
        //numbers[1, 0] = 45;
        //numbers[1, 1] = 50;
        //numbers[1, 2] = 55;



        //for (int row = 0; row < numbers.GetLength(0); row++)
        //{
        //    Console.Write("Row " + row + ": ");

        //    for (int column = 0; column < numbers.GetLength(1); column++)
        //    {
        //        Console.Write(numbers[row, column] + " ");

        //    }
        //    Console.WriteLine();

        //}
        //--------------------------------------------------------------

        //--------------------------------------------------
        //Write a program that takes a 2D array of integers as input and
        //calculates the average value for each row.
        //Display the average value of each row as the output.

            int totalRows = 3;
            int totalCols = 2;
            int[,] tra = new int[totalRows, totalCols];
            tra[0, 0] = 30;
            tra[0, 1] = 35;
            tra[1, 0] = 40;
            tra[1, 1] = 45;
            tra[2, 0] = 50;
            tra[2, 1] = 55;
            Console.WriteLine("The sum is :"+sumMultiDiemensional(tra));


    }
}
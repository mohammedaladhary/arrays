using System;
using System.Collections;
using System.Runtime.Intrinsics.X86;

internal class Program
{

    static int sumArray(int[] num)
    {
        int sum = 0;
        for (int i = 0; i < num.Length; i++)
        {
            sum += num[i];
   
        }
        return sum;
    }

    static int avgArray(int[] num )
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
        for(int i = 0;i < num.Length; i++)
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


        Console.WriteLine("enter the array size:");
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];


        Console.WriteLine("enter the elements:");
        for (int i = 0; i < arr.Length ; i++)
        {
            arr[i] = int.Parse(Console.ReadLine()) ;
        }

        Console.WriteLine("the sum is:" + sumArray(arr)); //15
        Console.WriteLine("the avg is:" + avgArray(arr)); //3

        Console.WriteLine("the max is :" + maxArray(arr)); //5
        Console.WriteLine("the min is :" + minArray(arr)); //1

        Console.WriteLine("count for even :" + countArrayEven(arr));
        Console.WriteLine("count for odd :" + countArrayOdd(arr));

        //Console.WriteLine("second largest is :" + secondLargest(arr)); //4
        Console.WriteLine("remove duplicate :" + removeDuplicate(arr)); //0




    }


}
using System;
using System.Runtime.Intrinsics.X86;

internal class Program
{

    static int SumArray(int[] num)
    {
        int sum = 0;
        for (int i = 0; i < num.Length; i++)
        {
            sum += num[i];
   
        }
        return sum;
    }

    static int AvgArray(int[] num )
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

    static int MinArray(int[] num)
    {
        int min = 0;
        for (int i = 0; i < num.Length; i++)
        {
          
            if (num[i] < min)
                min = num[i];
        }
        return min;
    }

    public static int MaxArray(int[] num)
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

    //public static int CountArray(int[] num)
    //{
    //    int max = 0;
    //    if (num[i] > max)
    //    {
    //        max = num[i];

    //    }
    //    return max;
    //}

    static void Main(string[] args, int [] num)
    {
        num = new int[1000];
        int n , m;
     

        Console.WriteLine("enter the array size:");
        n = int.Parse(Console.ReadLine());

        Console.WriteLine("enter the elements:");
        for (int i = 0; i < n; i++)
        {
            num[i] = int.Parse(Console.ReadLine()) ;
        }

        Console.WriteLine("the sum is:" + SumArray); //15
        Console.WriteLine("the avg is:" + AvgArray); //3
        Console.WriteLine("the max is :" + MaxArray); //5
        Console.WriteLine("the min is :" + MinArray); //1
        //Console.WriteLine("count :" + minArray);  //5
        //Console.WriteLine("second largest is :" + minArray); //4
        //Console.WriteLine("remove duplicate :" + minArray); //0




    }


}
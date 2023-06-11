internal class Program
{
    private static void Main(string[] args)
    {
        int[] num = { 1, 2, 3, 4, 5 };
        int sum = 0;
        for (int i = 0; i < num.Length; i++)
        {
            sum += num[i];
        }
        Console.WriteLine(sum);
    }
}
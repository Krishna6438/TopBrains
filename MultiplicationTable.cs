using System;
public class MultiplicationTable
{
    static int[] Row(int n, int upto)
    {
        int[] arr = new int[upto];

        for (int i = 1; i <= upto; i++)
        {
            arr[i - 1] = n * i;
        }
        return arr;

    }
    public static void Run()
    {
        int n = int.Parse(Console.ReadLine()!);
        int upto = int.Parse(Console.ReadLine()!);
        int[] arr = Row(n, upto);

        foreach (int var in arr)
        {
            Console.Write(var + " ");
        }
    }
}
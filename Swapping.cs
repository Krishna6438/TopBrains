using System;

public class Swapping
{

    static void SwapUsingRef(ref int a, ref int b)
    {
        a = a + b;
        b = a - b;
        a = a - b;
    }


    static void SwapUsingOut(int a, int b, out int x, out int y)
    {
        x = b;
        y = a;
    }

    public static void Run()
    {
        // ----- Using ref -----
        int m = 10, n = 20;
        Console.WriteLine($"Before ref swap: m = {m}, n = {n}");

        SwapUsingRef(ref m, ref n);

        Console.WriteLine($"After ref swap:  m = {m}, n = {n}");

        Console.WriteLine();

        // ----- Using out -----
        int a = 30, b = 40;
        Console.WriteLine($"Before out swap: a = {a}, b = {b}");

        int x, y;
        SwapUsingOut(a, b, out x, out y);

        Console.WriteLine($"After out swap:  x = {x}, y = {y}");
    }
}

// Lucky Numbers
using System;
public class Programming
{
    static int Sum(int n)
    {
        int sum = 0;
        while (n > 0)
        {
            sum += n % 10;
            n /= 10;
        }
        return sum;
    }

    static bool IsPrime(int n)
    {
        if (n <= 1) return false;
        if (n <= 3) return true;

        for (int i = 2; i * i <= n; i++)
        {
            if (n % i == 0)
            {
                return false;
            }
        }
        return true;
    }

    public static void Run()
    {
        int m = int.Parse(Console.ReadLine()!);
        int n = int.Parse(Console.ReadLine()!);

        int count = 0;

        for (int x = m; x <= n; x++)
        {
            // Must be non-prime
            if (!IsPrime(x))
            {
                int s1 = Sum(x);
                int s2 = Sum(x * x);

                if (s2 == s1 * s1)
                {
                    count++;
                }
            }
        }

        Console.WriteLine(count);
    }
}
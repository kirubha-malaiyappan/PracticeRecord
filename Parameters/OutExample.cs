using System;

internal static class OutExample
{
    public static void Run()
    {
        int a, b;
        Swap(out a, out b);
        Console.WriteLine($"Out Swap: {a}, {b}");
    }

    private static void Swap(out int x, out int y)
    {
        x = 10;
        y = 20;
    }
}

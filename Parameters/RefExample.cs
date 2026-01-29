using System;

internal static class RefExample
{
    public static void Run()
    {
        int a = 10, b = 20;
        Swap(ref a, ref b);
        Console.WriteLine($"Ref Swap: {a}, {b}");
    }

    private static void Swap(ref int x, ref int y)
    {
        int temp = x;
        x = y;
        y = temp;
    }
}

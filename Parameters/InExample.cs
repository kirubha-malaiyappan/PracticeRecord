using System;

internal static class InExample
{
    public static void Run()
    {
        int a = 10, b = 20;
        Swap(in a, in b);
    }

    private static void Swap(in int x, in int y)
    {
        Console.WriteLine("Cannot swap using in keyword");
    }
}

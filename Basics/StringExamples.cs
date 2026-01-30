using System;
using System.Globalization;

internal static class StringExamples
{
    public static void Run()
    {
        string s = "this is kirubha malaiappan.";
        TextInfo info = CultureInfo.CurrentCulture.TextInfo;

        Console.WriteLine(s.ToUpper());
        Console.WriteLine(info.ToTitleCase(s));
    }
    internal static void Print(string s)
    {
        for (int i = 0; i < s.Length; i++)
        {
            Console.WriteLine(s[i]); //string considered as an array
        }
    }


    internal static void Formatting(string s)
    {
        string firstName = "Kirubha";
        string lastName = " Malaiappan";
        Console.WriteLine("My name is {0} {1}", firstName, lastName);
        Console.WriteLine($"My name is {firstName} {lastName}");

    }
    internal static void InterpolationAndLiteral()
    {
        string firstName = "Kirubha";
        string path = @$"c:\{firstName}\""Users""";//double quotes in string
        Console.WriteLine(path);

    }
}

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
}

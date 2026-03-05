using System;
using System.Globalization;

public class StringExamples
{
    public void Run()
    {
        string s = "this is kirubha malaiappan.";
        TextInfo info = CultureInfo.CurrentCulture.TextInfo;

        Console.WriteLine(s.ToUpper());
        Console.WriteLine(info.ToTitleCase(s));
    }
    internal void Print(string s)
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
        string path = @$"c:\{firstName}\""Users""";//double quotes in string(this is for @)
        string hehe = $"\" hello \"";
        Console.WriteLine(path);

    }

    internal static void PadandTrim()
    {
        string firstName = "     Kirubha      ";
        string res = firstName.Trim();
        res = firstName.TrimStart();
        res = firstName.TrimEnd();
        res = firstName.PadLeft(10, '0');


    }

    internal static void Search()
    {
        string test = "This is a test string";
        bool res;
        int resInt;
        res = test.StartsWith("This");
        res = test.EndsWith(".txt"); // cna be used to find text format
        res = test.Contains("is");
        resInt = test.IndexOf("is");// ("is", 10) starts at 10th index
        resInt = test.LastIndexOf("test");// ("is", 45) starts from 45 and goes to start


    }

    
    public static void CompareToHelpers(string testA, string? testB)
    {
        int res = testA.CompareTo(testB);
        switch (res)
        {
            case > 0:
                Console.WriteLine($"CompareTo: {testB ?? "null"} comes before {testA}");
                break;
            default:
                break;
        }

    }
}

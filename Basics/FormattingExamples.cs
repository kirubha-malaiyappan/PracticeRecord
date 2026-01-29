internal static class FormattingExamples
{
    public static void Run()
    {
        string firstName = "Kirubha";
        string lastName = "Malaiappan";

        Console.WriteLine("My name is {0} {1}", firstName, lastName);
        Console.WriteLine($"My name is {firstName} {lastName}");
    }
}

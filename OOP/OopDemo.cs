using System;
using Oops;

internal static class OopDemo
{
    public static void Run()
    {
        Animal dog = new Dog("Puppy");
        dog.MakeSound();
        Console.WriteLine(dog.Name);
        Console.WriteLine(dog.Species);
    }
}

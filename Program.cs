
using Oops;
using System;
class Program : Object
{
   public static void Main(string[] args)
        
    {
        Dog obj = new Dog("Puppy");
        Animal a = obj as Animal;

        if (a is Animal)
        {
            Console.WriteLine(a.Name);
        }
        Console.WriteLine(a.GetHashCode());

        StringExamples se = new StringExamples();

        Console.WriteLine(se.ToString());

        
    }
}

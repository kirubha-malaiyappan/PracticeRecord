
using System.Reflection;
using Oops;

class Program : Object
{
    public static void Main(string[] args)

    {
        Type t = Type.GetType("Oops.Dog");
        PropertyInfo[] properties = t.GetProperties();
        foreach (PropertyInfo property in properties)
        {
            Console.WriteLine(property.Name);
        }


    }
}

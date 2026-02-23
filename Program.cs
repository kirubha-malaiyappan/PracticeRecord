
using C_Practice.Important;
using Oops;
using System;
class Program : Object
{
   public static void Main(string[] args)
        
    {
        //try
        //{
            int a = 6 / 5;
            if(a%2 == 1)
            {
                throw new DivideByOddNo();
           }
        //Console.WriteLine("haiii");

        //}
        //catch (DivideByOddNo ex)
        //{
        //    Console.WriteLine(ex.Message);

        //}
        //finally
        //{
        //    Console.WriteLine("program ended");
        //}
     

    }
}

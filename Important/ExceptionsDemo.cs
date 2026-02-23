using System;
using System.Collections.Generic;
using System.Text;

namespace C_Practice.Important
{
    internal class ExceptionsDemo
    {
       internal void print()
        {
            try
            {
                Console.WriteLine("Enter a");
                int a = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter b");
                int b = int.Parse(Console.ReadLine());
                Console.WriteLine("Result" + a / b);

            }
            catch(FormatException ex)
            {
                Console.WriteLine(ex.Message); 

            }
            catch(DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);

            }
            Console.WriteLine("Program Ended");
            
           

        }
    }
}

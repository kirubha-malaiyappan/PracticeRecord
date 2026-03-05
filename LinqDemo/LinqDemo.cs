using System;
using System.Collections.Generic;
using System.Text;

namespace C_Practice.LinqDemo
{
    public class LinqDemo
    {
        public static void Main(string[] args)

        {

            DateTime dateTime = DateTime.Now;
            DateOnly dateOnly = DateOnly.FromDateTime(DateTime.Now);
            TimeOnly timeOnly = TimeOnly.FromDateTime(DateTime.Now);
            Console.WriteLine(dateOnly.Day);
            Console.WriteLine(timeOnly.Minute);

        }

    }
}

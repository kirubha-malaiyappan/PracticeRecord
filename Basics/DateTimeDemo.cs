using System;
using System.Collections.Generic;
using System.Text;

namespace C_Practice.Basics
{
    internal class DateTimeDemo
    {
        DateTime dateTime = DateTime.Now;
        DateOnly dateOnly = DateOnly.FromDateTime(DateTime.Now);
        TimeOnly timeOnly = TimeOnly.FromDateTime(DateTime.Now);


    }
}

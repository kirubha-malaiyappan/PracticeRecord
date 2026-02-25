using System;
using System.Collections.Generic;
using System.Text;

namespace C_Practice.Debugging
{
    internal class BreakPointDemo
    {
        string name = "Timothy";
        string output = null;
        public void WeirdMethod()
        {
            for(int i =0; i< name.Length; i++)
            {
                if (i % 2 == 0)
                {
                    output += name.Substring(i, 1).ToLower();
                }
                else
                {
                    output += name.Substring(i, 1).ToUpper();
                }
            }


        }
    }
}

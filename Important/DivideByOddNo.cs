using System;
using System.Collections.Generic;
using System.Text;

namespace C_Practice.Important
{
    internal class DivideByOddNo : ApplicationException
    {
        public override string Message
        {
            get
            {
                return "Cannot Divide by odd number";
            }

        }
        

        
    }
}

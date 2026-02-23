using System;
using System.Collections.Generic;
using System.Text;

namespace C_Practice.OOP
{
    internal class Indexers
    {
        int id;
        string name, job, location;

        public object this[int index]
        {
            get
            {
                if (index == 1)
                    return id;
                if (index == 2)
                    return name;
                if (index == 3)
                    return job;
                if (index == 4)
                    return location;
                return null;
            }
            set
            {
                if (index == 1)
                   id=(int)value;
                if (index == 2)
                    name = (string) value;
                if (index == 3)
                    job = (string) job;
                if (index == 4)
                    location = (string) location;
               
            }

        }

    }
}

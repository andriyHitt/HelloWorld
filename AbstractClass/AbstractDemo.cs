using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    public abstract class AbstractDemo
    {
        
        public abstract string Name { get; }
        public abstract DateTime GetTime();
        public string Test()
        {
            return GetTime().ToString();
        }
    }

}

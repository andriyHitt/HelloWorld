using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    class MyClass : AbstractDemo
    {
        public override string Name => "10";

        public override DateTime GetTime()
        {
            return DateTime.Now;
        }
    }
}

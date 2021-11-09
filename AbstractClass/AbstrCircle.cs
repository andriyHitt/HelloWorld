using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    public abstract class AbstrCircle
    {
        private double _radius; 
        public AbstrCircle(double rP) { _radius = rP; }

        public double GetDiameter()
        {
            return _radius * 2;
        }
        public double GetLength()
        {
            return 2 * Math.PI * _radius;
        }
    }

}

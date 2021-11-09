using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    public class Wheel: AbstrCircle
    {
        private double _width;
        public double _weight;
        public Wheel(double rP, double widthP, double weightP)
            :base(rP)
        {
            _width = widthP;
            _weight = weightP;
        }
        public Wheel():base(0) { _width = 0; _weight = 0; }

        public double LinearSpeed(double period)
        {
            return this.GetLength() / period;
        }

        public double RateOfRotation(double period)
        {
            return 1 / period;
        }
        public double CornerSpeed(double period)
        {
            return 2 * Math.PI * RateOfRotation(period);
        }
    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circle
{
    public class Wheel:ClassCircle
    {
        public double Width;
        public double Weight;
        public Wheel(double rP, double widthP, double weightP)
            :base(rP)
        {
            R = rP;
            Width = widthP;
            Weight = weightP;
        }
        public Wheel() { Width = 0; Weight = 0; }
    }
}

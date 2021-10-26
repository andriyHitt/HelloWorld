using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circle
{
    public class ClassCircle
    {
        public double R;
        public ClassCircle(double rP) { R = rP; }
        public ClassCircle() { R = 0; }
        public double GetDiameter()
        {
            return this.R * 2;
        }
        
    }
}

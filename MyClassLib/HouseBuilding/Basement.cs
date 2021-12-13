using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClassLib.HouseBuilding
{
    public class Basement : PartOfHouse
    {
        public Basement(uint buildTime) : base(buildTime) { }
        public Basement() : base(300) { }
    }
}

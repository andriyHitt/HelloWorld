using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClassLib.HouseBuilding
{
    public class Roof : PartOfHouse
    {
        public Roof(uint buildTime) : base(buildTime) { }
        public Roof() : base(150) { }

    }
}

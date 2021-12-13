using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClassLib.HouseBuilding
{
    public class Door : PartOfHouse
    {
        public Door(uint buildTime) : base(buildTime) { }
        public Door() : base(16) { }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClassLib.HouseBuilding
{
    public class Wall : PartOfHouse
    {
        public Wall(uint buildTime) : base(buildTime) { }
        public Wall() : base(200) { }

    }
}

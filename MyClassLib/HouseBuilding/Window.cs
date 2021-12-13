using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClassLib.HouseBuilding
{
    public class Window : PartOfHouse
    {
        public Window(uint buildTime) : base(buildTime) { }
        public Window() : base(16) { }

    }
}

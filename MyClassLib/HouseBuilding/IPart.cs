using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClassLib.HouseBuilding
{
    interface IPart
    {
        bool IsFinished { get; set; }
        double MyProgress { get; set; }
    }
}

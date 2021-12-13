using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClassLib.HouseBuilding
{
    interface IWorker
    {
        bool isWorking { get; set; }
        void Work();

    }
}

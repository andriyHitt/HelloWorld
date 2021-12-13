using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClassLib.HouseBuilding
{
    public class Worker : IWorker
    {
        private bool _isWorking = false;
        public bool isWorking { get => _isWorking; set => _isWorking = value; }

        public void Work()
        {
            if (_isWorking)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("I'm a worker, I build the house");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("I'm a worker, at this time I don't work");
                Console.ResetColor();
            }
        }
    }
}

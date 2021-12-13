using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClassLib.HouseBuilding
{
    public class TeamLeader : IWorker
    {
        private bool _isWorking = false;
        public bool isWorking { get => _isWorking; set => _isWorking = value; }

        public void Work()
        {
            if (_isWorking)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("I'm a team leader, I do control and make report");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("I'm a team leader, at this time I don't work");
                Console.ResetColor();
            }
        }
        public void Report(ref House house)
        {
            uint resWalls = 0;
            uint resWindows = 0;
            uint resDoors = 0;
            
            for (ushort i = 0; i < house.MyWalls.Length; i++)
            {
                resWalls += (uint)house.MyWalls[i].MyProgress;
            }
            for (ushort i = 0; i < house.MyWindows.Length; i++)
            {
                resWindows += (uint)house.MyWindows[i].MyProgress;
            }
            for (ushort i = 0; i < house.MyDoors.Length; i++)
            {
                resDoors += (uint)house.MyDoors[i].MyProgress;
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"At this time was do {house.MyProgress}% of according to the project");
            Console.ResetColor();
            Console.WriteLine($"Basement is \t{house.MyBasement.MyProgress}%\n" +
                $"Walls is \t{resWalls/house.MyWalls.Length}%\n" +
                $"Roof is \t{house.MyRoof.MyProgress}%\n" +
                $"Windows is \t{resWindows/house.MyWindows.Length}%\n" +
                $"Doors is \t{resDoors/house.MyDoors.Length}%.");
        }
    }
}

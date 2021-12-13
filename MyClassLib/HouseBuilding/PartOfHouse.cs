using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClassLib.HouseBuilding
{
    public abstract class PartOfHouse : IPart
    {
        private bool _isFinished;
        private double _progress;
        private uint _buildTime; //термін будівництва люд/год
        public PartOfHouse(uint buildTime) { _isFinished = false; _progress = 0; _buildTime = buildTime; }

        public bool IsFinished { get => _isFinished; set => _isFinished = value; }
        public double MyProgress { get => _progress; set => _progress = value; }
        public uint MyBuildTime { get => _buildTime; set => _buildTime = value; }

        public uint timeOfBuildProgress(ushort numbOfWorker)
        {
            const ushort workingTime = 8; // тривалість робочого дня
            double time = ((double)MyBuildTime / numbOfWorker) / (double)workingTime;
            uint res = (uint)time;
            if (res < time)
            {
                res += 1;
            }
            return res;
        }

        public void BuildProgress(ref Worker[] workers /*ushort numbOfWorker*/)
        {
            if (workers != null)
            {
                for (ushort k = 0; k < workers.Length; k++)
                {
                    workers[k].isWorking = true;
                }
                for (ushort i = 0; i < timeOfBuildProgress((ushort)workers.Length); i++)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"Working day {i + 1} for build this part of house was starting");
                    Console.ResetColor();
                    Console.WriteLine("Press any key for building");
                    Console.ReadKey();

                    for (ushort k = 0; k < workers.Length; k++)
                    {
                        workers[k].Work();
                    }
                    MyProgress += (100 / (double)timeOfBuildProgress((ushort)workers.Length));
                }
                for (ushort k = 0; k < workers.Length; k++)
                {
                    workers[k].isWorking = false;
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine("\nBuilding is not posible because are not workers");
                Console.ResetColor();
            }
            if (MyProgress == 100) 
            { 
                IsFinished = true;
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("This part of house is complete");
                Console.ResetColor();
            }
        }

    }
}

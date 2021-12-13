using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClassLib.HouseBuilding
{
    public class House
    {
        private Basement _basement;
        private Wall[] _walls;
        private Roof _roof;
        private Window[] _windows;
        private Door[] _doors;
        private ushort _progress = 0;
        public House(ushort numbOfWalls, ushort numbOfWindows, ushort numbOfDoors)
        {
            _basement = new Basement();
            _walls = new Wall[numbOfWalls];
            for (ushort i = 0; i < _walls.Length; i++)
            {
                _walls[i] = new Wall();
            }
            _roof = new Roof();
            _windows = new Window[numbOfWindows];
            for (ushort i = 0; i < _windows.Length; i++)
            {
                _windows[i] = new Window();
            }
            _doors = new Door[numbOfDoors];
            for (ushort i = 0; i < _doors.Length; i++)
            {
                _doors[i] = new Door();
            }
        }
        public ushort MyProgress { get => _progress; set => _progress = value; }
        public Basement MyBasement { get => _basement; }
        public Wall[] MyWalls { get => _walls; }
        public Roof MyRoof { get => _roof; }
        public Window[] MyWindows { get => _windows; }
        public Door[] MyDoors { get => _doors; }
    }
}

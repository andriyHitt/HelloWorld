using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClassLib.CarRacing
{
    public class Bus : Car
    {
        private string _busClass; // специфікація автобусу (міжміський, міський і т.і.)
        private uint _passangersCapasity;
        public Bus (string carBrand, double length, double clearance, double engineDisplacement, double enginePower, double wheelDiameter,
            string transmission, string color, string typeOfFuel, double tankFuelCapacity, uint maxSpeed, uint odometerRun, double avgFuelConsuption, 
            string busClass, uint passangersCapasity) : 
            base(carBrand, length, clearance, engineDisplacement, enginePower, wheelDiameter, transmission, 
                color, typeOfFuel, tankFuelCapacity, maxSpeed, odometerRun, avgFuelConsuption)
        {
            _busClass = busClass;
            _passangersCapasity = passangersCapasity;
        }

        public string MyBusClass { get => _busClass; set => _busClass = value; }
        public uint MyPassengersCapasity { get => _passangersCapasity; set => _passangersCapasity = value; }

        public override void Info()
        {
            base.Info();
            Console.WriteLine($" Bus class: {_busClass} Passangers capasity: {_passangersCapasity}");
        }
    }
}

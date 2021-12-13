using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClassLib.CarRacing
{
    public class Truck : Car
    {
        private string _truckClass;
        private uint _payload; // вантажопід'ємність
        public Truck (string carBrand, double length, double clearance, double engineDisplacement, double enginePower, double wheelDiameter,
            string transmission, string color, string typeOfFuel, double tankFuelCapacity, uint maxSpeed, uint odometerRun, double avgFuelConsuption,
            string truckClass, uint payload) :
            base(carBrand, length, clearance, engineDisplacement, enginePower, wheelDiameter, transmission, color, typeOfFuel,
                tankFuelCapacity, maxSpeed, odometerRun, avgFuelConsuption)
        {
            _truckClass = truckClass;
            _payload = payload;
        }

        public string MyTruckClass { get => _truckClass; set => _truckClass = value; }
        public uint MyPayload { get => _payload; set => _payload = value; }

        public override void Info()
        {
            base.Info();
            Console.WriteLine($" Truck class: {_truckClass} Payload: {_payload}");
        }
    }
}

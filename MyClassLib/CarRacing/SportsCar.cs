using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClassLib.CarRacing
{
    public class SportsCar : Car
    {
        private string _sportsClass;
        public SportsCar(string carBrand, double length, double clearance, double engineDisplacement, double enginePower, double wheelDiameter,
            string transmission, string color, string typeOfFuel, double tankFuelCapacity, uint maxSpeed, uint odometerRun, double avgFuelConsuption,
            string sportsClass) : 
            base(carBrand, length, clearance, engineDisplacement, enginePower, wheelDiameter, transmission, color, typeOfFuel,
                tankFuelCapacity, maxSpeed, odometerRun, avgFuelConsuption)
        { _sportsClass = sportsClass; }

        public string MySportsClass { get => _sportsClass; set => _sportsClass = value; }

        public override void Info()
        {
            base.Info();
            Console.WriteLine($" Sports class: {_sportsClass}");
        }
    }
}

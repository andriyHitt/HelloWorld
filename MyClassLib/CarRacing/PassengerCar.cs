using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClassLib.CarRacing
{
    public class PassengerCar : Car
    {
        private string _carBodyType; // тип кузову
        public PassengerCar(string carBrand, double length, double clearance, double engineDisplacement, double enginePower, double wheelDiameter,
            string transmission, string color, string typeOfFuel, double tankFuelCapacity, uint maxSpeed, uint odometerRun, double avgFuelConsuption,
            string carBodyType) :
            base(carBrand, length, clearance, engineDisplacement, enginePower, wheelDiameter, transmission, color, typeOfFuel,
                tankFuelCapacity, maxSpeed, odometerRun, avgFuelConsuption)
        { _carBodyType = carBodyType; }

        public string MyCarBodyType { get => _carBodyType; set => _carBodyType = value; }

        public override void Info()
        {
            base.Info();
            Console.WriteLine($" Car body type: {_carBodyType}");
        }
    }
}

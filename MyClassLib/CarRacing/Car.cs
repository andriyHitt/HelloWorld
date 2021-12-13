using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClassLib.CarRacing
{
    public abstract class Car
    {
		private string _carBrand;
		private double _length;
		private double _clearance;
		private double _engineDisplacement; // об'єм двигуна
		private double _enginePower; // потужність
		private double _wheelDiameter; 
		private string _transmission; 
		private string _color;
		private string _typeOfFuel;
		private double _tankFuelCapacity; // місткість паливного баку
		private uint _maxSpeed;
		private double _isFuel = 0; // датчик палива
		private uint _odometerRun; // одометер (пробіг авто)
		private uint _odometer_2 = 0; // лічильник для окремого вимірювання відстані, яку проїхав автомобіль
		private uint _speedometer = 0;
		private double _avgFuelConsuption; // середня витрата палива на 100 км
		readonly Random rand = new();

		public Car() : this("Unknown", 0, 0, 0, 0, 0, "Unknown", "Unknown", "Unknown", 0, 0, 0, 0) { }
		public Car(string carBrand, double length, double clearance, double engineDisplacement, double enginePower, double wheelDiameter,
			string transmission, string color, string typeOfFuel, double tankFuelCapacity, uint maxSpeed, uint odometerRun, double avgFuelConsuption)
		{
			_carBrand = carBrand;
			_length = length;
			_clearance = clearance;
			_engineDisplacement = engineDisplacement;
			_enginePower = enginePower;
			_wheelDiameter = wheelDiameter;
			_transmission = transmission;
			_color = color;
			_typeOfFuel = typeOfFuel;
			_maxSpeed = maxSpeed;
			_odometerRun = odometerRun;
			_avgFuelConsuption = avgFuelConsuption;
		}
		public string MyBrand { get => _carBrand; set => _carBrand = value; }
		public double MyLenth { get => _length; set => _length = value; }
		public double MyClearance { get => _clearance; set => _clearance = value; }
		public double MyEngineDisplace { get => _engineDisplacement; set => _engineDisplacement = value; }
		public double MyEnginePower { get => _enginePower; set => _enginePower = value; }
		public double MyWheelDiameter { get => _wheelDiameter; set => _wheelDiameter = value; }
		public string MyTransmission { get => _transmission; set => _transmission = value; }
		public string MyColor { get => _color; set => _color = value; }
		public string MyTypeOfFuel { get => _typeOfFuel; set => _typeOfFuel = value; }
		public double MyTankFuelCapacity { get => _tankFuelCapacity; set => _tankFuelCapacity = value; }
		public uint MyMaxSpeed { get => _maxSpeed; set => _maxSpeed = value; }
        public double MyFuel 
		{ 
			get => _isFuel;
			set
			{ 
				try
                {
					if (_isFuel == 0 && value <= _tankFuelCapacity)
					{
						_isFuel = value;
					}
					else if (_isFuel > 0 && value <= _tankFuelCapacity)
					{
						if (value <= (_tankFuelCapacity - _isFuel))
						{
							_isFuel += value;
						}
						else
                        {
							throw new Exception("This value is greater than tank capacity or free volume in the tank");
                        }
					}
					else
                    {
						throw new Exception("This value is greater than tank capacity or free volume in the tank");
					}
				}
				catch(Exception ex)
                {
					Console.WriteLine($"WARNING ! {ex}. \n" +
						$"The fuel tank will be filled to the maximum value.");
					_isFuel = _tankFuelCapacity;
                }
			}
		}

        public uint MyOdometerRun { get => _odometerRun; set => _odometerRun = value; }
        public double MyAvgFuelConsuption { get => _avgFuelConsuption; set => _avgFuelConsuption = value; }

        public uint MySpeed { get => _speedometer; set => _speedometer = value; }
        public uint MyCurrentOdometer_2 { get => _odometer_2; set => _odometer_2 = value; }

        public void Init(string carBrand, double length, double clearance, double engineDisplacement, double enginePower, double wheelDiameter,
			string transmission, string color, string typeOfFuel, double tankFuelCapacity, uint maxSpeed, uint odometerRun, double avgFuelConsuption)
		{
			MyBrand = carBrand;
			MyLenth = length;
			MyClearance = clearance;
			MyEngineDisplace = engineDisplacement;
			MyEnginePower = enginePower;
			MyWheelDiameter = wheelDiameter;
			MyTransmission = transmission;
			MyColor = color;
			MyTypeOfFuel = typeOfFuel;
			MyTankFuelCapacity = tankFuelCapacity;
			MyMaxSpeed = maxSpeed;
			MyOdometerRun = odometerRun;
			MyAvgFuelConsuption = avgFuelConsuption;
		}

		public virtual void Info()
		{
			Console.ForegroundColor = ConsoleColor.Green;
			Console.Write($"Car brand: {_carBrand}");
			Console.ResetColor();
			Console.Write($" Color: {_color}" +
				$" Engine displasement: {_engineDisplacement} l" +
				$" Engine power: {_enginePower} hp" +
				$" Max speed: {_maxSpeed} km/h" +
				$" Transmission: {_transmission}" +
				$" Type of fuel: {_typeOfFuel}");
		}


		public void Go(uint distance, uint changeSpeedKm)
        {
			if (_isFuel != 0)
            {
				for (uint i = 0; i < distance; i++)
				{
					MyFuel -= ((i * 100) / _avgFuelConsuption);
					MyOdometerRun += i;
					MyCurrentOdometer_2 += i;
					
					MySpeed = (uint)rand.Next(1, (int)MyMaxSpeed);

					if (i == changeSpeedKm && i != distance)
                    {
						MySpeed = (uint)rand.Next(1, (int)MyMaxSpeed);
						changeSpeedKm += i;
					}
				}
				MySpeed = 0;
			}
		}

		public void GoOutOnTheStart()
        {
			if (_isFuel != 0)
            {
				MyFuel += (_tankFuelCapacity - MyFuel);
			}
			if (_odometer_2 != 0)
            {
				MyCurrentOdometer_2 = 0;
            }
        }

	}
}

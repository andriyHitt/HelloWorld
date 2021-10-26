using System;
using System.Collections.Generic;
using System.Text;

namespace DZ2_Hitt
{
    public partial class Car
    {
		private string _carBrand;
		private double _length;
		private double _clearance;
		private double _engineDisplacement;
		private double _enginePower;
		private double _wheelDiameter;
		private string _transmission;
		private string _color;
		private string _typeOfFuel;
		public static int Count;
		public Car() : this("Unknown", 0, 0, 0, 0, 0, "Unknown", "Unknown", "Unknown") { }
		public Car(string carBrand, double length, double clearance, double engineDisplacement, double enginePower, double wheelDiameter, 
			string transmission, string color, string typeOfFuel) 
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
				Count++; 
			}
		static Car() { Count = 0; }
        public string SetBrand { get=>_carBrand; set=> _carBrand = value; }
        public double SetLenth { get => _length; set => _length = value; }
        public double SetClearance { get=> _clearance; set=> _clearance = value; }
        public double SetEngDisplace { get=> _engineDisplacement; set=> _engineDisplacement = value; }
        public double SetEngPower { get=> _enginePower; set=> _enginePower = value; }
        public double SetWheelD { get=> _wheelDiameter; set=> _wheelDiameter = value; }
        public string SetTransmission { get=>_transmission; set=> _transmission = value; }
        public string SetColor { get=>_color; set=> _color = value; }
        public string SetTypeOfFuel { get=>_typeOfFuel; set=> _typeOfFuel = value; }

        public void Init()
        {
			Console.WriteLine("Enter car brand");
			SetBrand = Console.ReadLine();
			Console.WriteLine("Enter length of car");
			SetLenth = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine("Enter clearance of car");
			SetClearance = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine("Enter engine displacement of car");
			SetEngDisplace = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine("Enter engine power of car");
			SetEngPower = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine("Enter wheels diameter of car");
			SetWheelD = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine("Enter transmission of car");
			SetTransmission = Console.ReadLine();
			Console.WriteLine("Enter color of car");
			SetColor = Console.ReadLine();
			Console.WriteLine("Enter type of fuel of car");
			SetTypeOfFuel = Console.ReadLine();
		}
		public void Init(string carBrand, double length, double clearance, double engineDisplacement, double enginePower, double wheelDiameter,
			string transmission, string color, string typeOfFuel)
		{
			SetBrand = carBrand;
			SetLenth = length;
			SetClearance = clearance;
			SetEngDisplace = engineDisplacement;
			SetEngPower = enginePower;
			SetWheelD = wheelDiameter;
			SetTransmission = transmission;
			SetColor = color;
			SetTypeOfFuel = typeOfFuel;
		}
    }
}

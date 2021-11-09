using System;

namespace AbstractClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Wheel a = new Wheel(16.0, 55.0, 2.5);
            
            
            Console.WriteLine($"Diameter a = {a.GetDiameter()}\nLength a = {a.GetLength()}");
        }
    }
}

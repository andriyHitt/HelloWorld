using System;

namespace Enam_rec
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bool metod:");
            BoolGender.IsMan(true);
            BoolGender.IsMan(false);

            Console.WriteLine("\nEnam metod:");

            EnumGender.IsEMan(Gender.Man);
            EnumGender.IsEMan(Gender.Woman);


        }
    }
}

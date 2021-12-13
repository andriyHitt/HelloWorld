using System;
using System.Globalization;


namespace GenericDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new GenericList<int>();
            for (int i = 0; i < 10; i++) list.AddHead(i);

            foreach (int i in list) Console.Write(i + "");


            Console.WriteLine();

            var beginDay = DateTime.Now.BeginOfDay();
            Console.WriteLine(beginDay);
            var endDay = DateTime.Now.EndOfDay();
            Console.WriteLine(endDay);
            var beginYear = DateTime.Now.BeginOfYear();
            Console.WriteLine(beginYear);
            var endYear = DateTime.Now.EndOfYear();
            Console.WriteLine(endYear);
            var beginMonth = DateTime.Now.BeginOfMonth();
            Console.WriteLine(beginMonth);
            var endMonth = DateTime.Now.EndOfMonth();
            Console.WriteLine(endMonth);
            var beginWeekUS = DateTime.Now.BeginOfWeek();
            Console.WriteLine($"US system -> Begin of week is: {beginWeekUS}");
            var endWeekUS = DateTime.Now.EndOfWeek();
            Console.WriteLine($"US system -> End of week is: {endWeekUS}");
            //var calendar = Calendar
            //var beginWeek = DateTime.Now.BeginOfWeek();
            var beginQwarter = DateTime.Now.BeginOfQwarter();
            Console.WriteLine(beginQwarter);
        }
    }
}

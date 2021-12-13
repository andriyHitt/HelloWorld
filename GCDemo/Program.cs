using System;
using System.Collections.Generic;

namespace GCDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var demoClass = new DemoClassGC())
            {

            }
            
            //var list = new List<DemoClassGC>();

            var start = DateTime.Now;

            for (int i = 0; i < 2; i++)
            {
                var list = new List<DemoClassGC>();

                for (int j = 0; j < 10; j++)
                {
                    list.Add(new DemoClassGC { FirstName = "Petrenko", Name = "Ivan", GroupID = j });
                }
                //Console.WriteLine($"{GC.GetTotalMemory(false)}");
                GC.Collect();
                //GC.WaitForPendingFinalizers();
            }
            var end = DateTime.Now;
            Console.WriteLine($"All time: {end - start}");
            Console.WriteLine("Hello World!");

            Console.ReadKey();
        }
    }
}

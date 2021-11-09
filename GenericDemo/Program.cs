using System;

namespace GenericDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new GenericList<int>();
            for (int i = 0; i < 10; i++) list.AddHead(i);

            foreach (int i in list) Console.Write(i + "");

            

            //var beginDay = DateTime
        }
    }
}

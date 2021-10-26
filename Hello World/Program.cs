using System;

namespace Hello_World
{
    class Program
    {
        static void Main(string[] args)
        {
            int res = 0;

            foreach (var arg in args)
            {
                Console.Write(arg);
                Console.Write("+");

                int num = Int32.Parse(arg);
                res += num;

            }
            Console.Write(" = " + res.ToString());
        }
    }
}

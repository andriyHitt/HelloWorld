using System;

namespace Type
{
    class Program
    {
        
        static void Main(int[] args)
        {
            int res = 0;

            foreach(int arg in args)
            {
                res += arg;
                Console.Write(arg.ToString(), " + ");

            }
            Console.Write(" = ", res.ToString());
        }
    }
}

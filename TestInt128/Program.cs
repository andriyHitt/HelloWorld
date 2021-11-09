using System;
using UInt128S;

namespace TestInt128
{
    
    class Program
    {
        static void Main(string[] args)
        {
            //ulong i = 1;
            //ulong k = 2;
            //ulong j = i - k;
            //Console.WriteLine($"i - k = {j}");
            
            
            UInt128 a = new UInt128(1, 8);
            UInt128 b = new UInt128(4, 8);

            a++;
            b--;

            if(a == b)
            {
                Console.WriteLine("a == b");
            }
            else if(a != b)
            {
                Console.WriteLine("a != b");
                if (a > b)
                {
                    Console.WriteLine("a > b");
                }
                else if(a < b)
                    Console.WriteLine("a < b");
            }
            Console.WriteLine($"a._lo = {a[0]}, a._hi = {a[1]}");
            Console.WriteLine($"b._lo = {b[0]}, b._hi = {b[1]}");

            UInt128 c = a + b;
            Console.WriteLine($"a + b = (c._lo = {c[0]}, c.hi = {c[1]})");

            UInt128 e = a / b;
            Console.WriteLine($"a / b = (e._lo = {e[0]}, e.hi = {e[1]})");


            var startDate = DateTime.Now;

            UInt128 d = a * b;
            Console.WriteLine($"a * b = (d._lo = {d[0]}, d.hi = {d[1]})");

            var endDate = DateTime.Now;
            Console.WriteLine($"Action time{endDate - startDate}");
        }
    }
}

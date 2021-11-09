using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enam_rec
{
    public static class BoolGender
    {
        /// <summary>
        /// Значення true => Man
        /// Значення false => Woman
        /// </summary>
        /// <param name="val"></param>
        public static void IsMan(bool val)
        {
            if (val)
                Console.WriteLine("It's man");
            else
                Console.WriteLine("It's woman");
        }
    }
}

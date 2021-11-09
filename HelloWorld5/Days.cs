using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enam_rec
{
    internal enum Days // : Byte => в байтах
    {
        Понеділок, 
        Вівторок, // можна присваювати  різні значення = 12 і т.і. (для байта до 255)
        Середа, 
        Четвер, 
        Пятниця, 
        Субота, 
        Неділя
    }
}

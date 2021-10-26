using System;
using System.Collections.Generic;
using System.Text;

namespace DZ1_Hitt
{
    public class Zavd_2
    {
        private int Result;
        private bool Flag;
        public Zavd_2() { Result = 0; Flag = false; }
        public bool LuckyNum(int Num)
        {
            for(int i = 0; i < 6; ++i)
            {
               if(i < 3) { Result += (Num % 10); }
               else { Result -= (Num % 10); }
               Num /= 10;
            }
            if(Result == 0) { Flag = true; }
            return Flag;
        }
    }
}
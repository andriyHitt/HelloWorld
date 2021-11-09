using System;

namespace UInt128S
{
    public readonly struct UInt128 /*: IDisposable*/
    {
        private readonly ulong _lo;
        private readonly ulong _hi;

        public UInt128(ulong hi, ulong lo)
        {
            _hi = hi;
            _lo = lo;
        }
        public ulong this[int index]
        {
            get { return index == 0 ? _lo : _hi; }
        }
        public static bool operator ==(UInt128 a, UInt128 b)
        {
            if (a._lo != b._lo) return false;
            return a._hi == b._hi;
        }
        public static bool operator !=(UInt128 a, UInt128 b)
        {
            if (a._lo != b._lo) return true;
            return a._hi != b._hi;
        }
        public static bool operator <(UInt128 a, UInt128 b)
        {
            if (a._lo < b._lo || a._lo == b._lo && a._hi < b._hi) return true;
            else return false;
        }
        public static bool operator >(UInt128 a, UInt128 b)
        {
            if (a._lo > b._lo || a._lo == b._lo && a._hi > b._hi) return true;
            else return false;
        }

        public static bool operator >=(UInt128 a, UInt128 b)
        {
            return !(a < b);
        }
        public static bool operator <=(UInt128 a, UInt128 b)
        {
            return !(a > b);
        }

        public static implicit operator UInt128(ulong a)
        {
            return new UInt128(0, a);
        }
        public static explicit operator ulong(UInt128 value)
        {
            return value._lo;
        }
        public static UInt128 operator ++(UInt128 a)
        {
            ulong i_lo = a._lo;
            ulong i_hi = a._hi;
            i_lo++;
            if(i_lo < a._lo)
            {
                i_hi++;
            }
            return new UInt128(i_hi, i_lo);
        }
        public static UInt128 operator --(UInt128 a)
        {
            ulong d_lo = a._lo;
            ulong d_hi = a._hi;
            d_lo--;
            if (d_lo > a._lo)
            {
                d_hi--;
            }
            return new UInt128(d_hi, d_lo);
        }
        public static UInt128 operator +(UInt128 a, UInt128 b)
        {
            ulong r = a._lo + b._lo;
            if (r < a._lo && r < b._lo)
            {
                return new UInt128(a._hi + b._hi + 1, r);
            }
            return new UInt128(a._hi + b._hi, r);
        }
        public static UInt128 operator -(UInt128 a, UInt128 b)
        {
            ulong r = a._lo - b._lo;
            if (r > a._lo)
            {
                return new UInt128(a._hi - b._hi - 1, r);
            }
            return new UInt128(a._hi - b._hi, r);
        }
        public static UInt128 operator *(UInt128 a, UInt128 b)
        {
            while (b._hi != 0 && b._lo != 0)
            {
                a += a;
                b--;
            }
            return a;
        }

        public static UInt128 operator /(UInt128 a, UInt128 b)
        {
            ulong result = 0;
            while (a._hi >= (a - b)._hi)
            {
                a -= b;
                result++;
            }
            return result;
        }

        public static UInt128 operator &(UInt128 a, UInt128 b) => new UInt128(a._hi & b._hi, a._lo & b._lo);
        public static UInt128 operator >>(UInt128 value, int count)
        {
            if (count >= 128) return 0;
            if (count >= 64) return value._hi >> count;
            return new UInt128(value._hi >> count, value._hi << (64 - count) | value._lo >> count);
        }
        public static UInt128 operator <<(UInt128 value, int count)
        {
            if (count >= 128) return 0;
            if (count >= 64) return new UInt128(value._lo << count, 0);
            return new UInt128(value._hi << count | value._lo >> (64 - count), value._lo << count);

        }
        //public static UInt128 operator *(UInt128 a, UInt128 b)
        //{
        //    UInt128 result = 0;
        //    for (int i = 0; i < 128; i++)
        //    {
        //        if ((b & 1) > 0) result += a;
        //        a <<= 1;
        //        b >>= 1;
        //    }
        //    return result;
        //}

        public override bool Equals(object obj)
        {
            throw new NotImplementedException();
        }

        public override int GetHashCode()
        {
            throw new NotImplementedException();
        }

        //public static UInt128 GetUInt()
        //{
        //    var a = 10;
        //    var b = a.GetType();
        //    return new UInt128(1, "Peter");
        //}
        //public void Dispose()
        //{
        //    throw new NotImplementedException();
        //}
    }
}

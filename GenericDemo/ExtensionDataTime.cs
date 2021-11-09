using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericDemo
{
    public static class ExtensionDatatime
    {
        public static DateTime BeginOfDay(this DateTime dt) => new DateTime(dt.Year, dt.Month, dt.Day, 0, 0, 0);

        public static DateTime EndOfDay(this DateTime dt) => new DateTime(dt.Year, dt.Month, dt.Day, 23, 59, 59);

        public static DateTime BeginOfYear(this DateTime dt) => new DateTime(dt.Year, 1, 1, 0, 0, 0);
        public static DateTime EndOfYear(this DateTime dt) => new DateTime(dt.Year, 12, 31, 23, 59, 59);
        public static DateTime BeginOfMonth(this DateTime dt) => new DateTime(dt.Year, 1, 1, 0, 0, 0);
        public static DateTime EndOfMonth(this DateTime dt) => new DateTime(dt.Year, dt.Month, DateTime.DaysInMonth(dt.Year, dt.Month), 23, 59, 59);
    }

}

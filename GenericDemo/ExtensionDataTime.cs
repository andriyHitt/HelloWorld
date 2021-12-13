using System;
using System.Collections.Generic;
using System.Globalization;
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
        public static DateTime BeginOfMonth(this DateTime dt) => new DateTime(dt.Year, dt.Month, 1, 0, 0, 0);
        public static DateTime EndOfMonth(this DateTime dt) => new DateTime(dt.Year, dt.Month, DateTime.DaysInMonth(dt.Year, dt.Month), 23, 59, 59);
        public static DateTime BeginOfQwarter(this DateTime dt) /*=> new DateTime(dt.Year, ((int)dt.Month / 3) * 3 + 1, 1, 0, 0, 0);*/
        {
            if (dt.Month >= 1 && dt.Month <= 3)
            {
                return dt.AddMonths(-(3 - dt.Month)).BeginOfMonth();
            }
            else if (dt.Month >= 4 && dt.Month <= 6)
            {
                return dt.AddMonths(-(6 - dt.Month)).BeginOfMonth();
            }
            else if (dt.Month >= 7 && dt.Month <= 9)
            {
                return dt.AddMonths(-(9 - dt.Month)).BeginOfMonth();
            }
            else return dt.AddMonths(-(12 - dt.Month)).BeginOfMonth();
        }
        public static DateTime BeginOfWeek(this DateTime dt)
        {
            var week = (int)dt.DayOfWeek;
            return dt.AddDays(-week).BeginOfDay();
        }
        public static DateTime EndOfWeek(this DateTime dt)
        {
            var week = (int)dt.DayOfWeek;
            return dt.AddDays(week).EndOfDay();
        }
        public static DateTime BeginOfWeek(this DateTime dt, Calendar calendar)
        {
            var week = (int)calendar.GetDayOfWeek(dt);
            return dt.AddDays(-week).BeginOfDay();
        }
    }

}

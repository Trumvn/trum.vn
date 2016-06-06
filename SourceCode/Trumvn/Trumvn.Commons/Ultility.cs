using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trumvn.Commons
{
    public static class Ultility
    {
        public static string NormalizeSqlString(string source)
        {
            return source;
            //return (!String.IsNullOrEmpty(source)? source.Replace("'", "''") : null);
        }

        public static string GetDefaultCurrencySymbol()
        {
            return System.Configuration.ConfigurationManager.AppSettings[Constants.APP_SETTING_CURRENCY_SYMBOL_DEFAULT];
        }

        public static bool IsValidEmailAddress(string emailAddress)
        {
            if (!String.IsNullOrEmpty(emailAddress))
                return System.Text.RegularExpressions.Regex.IsMatch(emailAddress, @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", System.Text.RegularExpressions.RegexOptions.IgnoreCase);
            return false;
        }

        public static int GetUnixTimestamp()
        {
            Int32 unixTimestamp = (Int32)(DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1))).TotalSeconds;
            return unixTimestamp;
        }

        public static List<String> GetMatches(String source)
        {
            List<String> keys = new List<string>();

            string pattern = @"{{(.+?)}}";
            System.Text.RegularExpressions.MatchCollection mc = System.Text.RegularExpressions.Regex.Matches(source, pattern);
            foreach (System.Text.RegularExpressions.Match m in mc)
            {
                keys.Add(m.Value);
            }

            return keys;
        }

        public static DateTime GetStartOfWeek(DateTime dt, DayOfWeek startOfWeek)
        {
            int diff = dt.DayOfWeek - startOfWeek;
            if (diff < 0)
            {
                diff += 7;
            }

            return dt.AddDays(-1 * diff).Date;
        }

        public static DateTime GetNextWeekday(DateTime start, DayOfWeek day)
        {
            // The (... + 7) % 7 ensures we end up with a value in the range [0, 6]
            int daysToAdd = ((int)day - (int)start.DayOfWeek + 7) % 7;
            return start.AddDays(daysToAdd);
        }

        public static int MonthDifference(this DateTime lValue, DateTime rValue)
        {
            return (lValue.Month - rValue.Month) + 12 * (lValue.Year - rValue.Year);
        }

        public static double DayDifference(this DateTime lValue, DateTime rValue)
        {
            return (lValue - rValue).TotalDays;
        }

        public static DateTime GetFirstDateOfMonth(DateTime dateTime)
        {
            return new DateTime(dateTime.Year, dateTime.Month, 1);
        }

        public static DateTime GetLastDateOfMonth(DateTime dateTime)
        {
            return new DateTime(dateTime.Year, dateTime.Month, DateTime.DaysInMonth(dateTime.Year, dateTime.Month));
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trumvn.Commons
{
    public static class DatetimeHelper
    {
        public static TimeRange GetTimeRange(Commons.Constants.TRANSACTION_FILTER tr, DateTime queryDate)
        {
            DateTime fromDate = DateTime.Today;
            DateTime endDate = fromDate.AddHours(23);

            switch (tr)
            {
                case Commons.Constants.TRANSACTION_FILTER.TODAY:
                    {
                        fromDate = DateTime.Today;
                        endDate = DateTime.Today.AddHours(23);
                    }
                    break;
                case Commons.Constants.TRANSACTION_FILTER.THIS_WEEK:
                    {
                        fromDate = Commons.Ultility.GetStartOfWeek(DateTime.Now, DayOfWeek.Monday);
                        endDate = Commons.Ultility.GetNextWeekday(DateTime.Now, DayOfWeek.Sunday);
                    }
                    break;
                case Commons.Constants.TRANSACTION_FILTER.THIS_YEAR:
                    {
                        fromDate = new DateTime(fromDate.Year, 1, 1);
                        endDate = fromDate.AddMonths(12).AddDays(-1);
                    }
                    break;
                case Commons.Constants.TRANSACTION_FILTER.THIS_MONTH:
                    {
                        fromDate = new DateTime(fromDate.Year, fromDate.Month, 1);
                        endDate = fromDate.AddMonths(1).AddDays(-1);
                    }
                    break;
                case Commons.Constants.TRANSACTION_FILTER.CUSTOM_DATE:
                    {
                        fromDate = new DateTime(queryDate.Year, queryDate.Month, queryDate.Day);
                        endDate = fromDate.AddHours(23);
                    }
                    break;
                case Commons.Constants.TRANSACTION_FILTER.CUSTOM_WEEK:
                    {
                        int delta = DayOfWeek.Monday - queryDate.DayOfWeek;
                        fromDate = queryDate.AddDays(delta);
                        endDate = fromDate.AddDays(7);
                    }
                    break;
                case Commons.Constants.TRANSACTION_FILTER.CUSTOM_MONTH:
                    {
                        fromDate = new DateTime(queryDate.Year, queryDate.Month, 1);
                        endDate = fromDate.AddMonths(1).AddDays(-1);
                    }
                    break;
                case Commons.Constants.TRANSACTION_FILTER.CUSTOM_YEAR:
                    {
                        fromDate = new DateTime(queryDate.Year, 1, 1);
                        endDate = fromDate.AddYears(1).AddDays(-1);
                    }
                    break;
                default:
                    break;
            };

            return new TimeRange(fromDate, endDate);
        }
    }
}

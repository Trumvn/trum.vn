using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trumvn.Commons
{
    public class TimeRange
    {
        public DateTime From { get; set; }
        public DateTime End { get; set; }

        public TimeRange()
        {
            this.From = DateTime.Now;
            this.End = DateTime.Now;
        }

        public TimeRange(DateTime from, DateTime end)
        {
            this.From = from;
            this.End = end;
        }
    }
}

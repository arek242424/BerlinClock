using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BerlinClock.Classes
{
    public class TimeConverter : ITimeConverter
    {
        private IBerlinClockMain _berlinClock;
        public TimeConverter(IBerlinClockMain berlinClock)
        {
            _berlinClock = berlinClock;


        }

        public string convertTime(string aTime)
        {
            var result = _berlinClock.GetFullTime(aTime);
            return result;
        }
    }
}

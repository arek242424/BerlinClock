using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BerlinClock.Classes
{
    public class StringTimeHelper : IStringTimeHelper
    {

        const char TIME_SPLIT_CHAR = ':';

        public string GetHoursFromTime(string time)
        {
            if (!IsTimeFormatCorrect(time))
                return null;

            string hours = time.Split(TIME_SPLIT_CHAR)[0];
            return hours;
        }

        public string GetMinutesFromTime(string time)
        {
            if (!IsTimeFormatCorrect(time))
                return null;

            string minutes = time.Split(TIME_SPLIT_CHAR)[1];
            return minutes;
        }

        public string GetSecondsFromTime(string time)
        {
            if (!IsTimeFormatCorrect(time))
                return null;

            string seconds = time.Split(TIME_SPLIT_CHAR)[2];
            return seconds;
        }

        private bool IsTimeFormatCorrect(string time)
        {
            TimeSpan dummyResult;
            return TimeSpan.TryParse(time, out dummyResult) && time.Split(TIME_SPLIT_CHAR).Length == 3;
        }
        
    }
}

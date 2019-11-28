using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BerlinClock.Classes
{
    public class BerlinClockMain : IBerlinClockMain
    {
        private IStringTimeHelper _stringTime;
        private IBerlinClockConverterHelper _berlinClockConverterHelper;

        public BerlinClockMain(IStringTimeHelper stringTime, IBerlinClockConverterHelper berlinClockConverterHelper)
        {
            _stringTime = stringTime;
            _berlinClockConverterHelper = berlinClockConverterHelper;
        }


        public string GetFullTime(string time)
        {
            return GetSecondState(time) + GetHours(time) + GetMinutes(time);
        }

        public string GetHours(string time)
        {
            string result = "";
            int hours;
            bool successParse = int.TryParse(_stringTime.GetHoursFromTime(time), out hours);
            if(successParse)
            {
                result = _berlinClockConverterHelper.ChangeHoursIntoBerlinClockFiveHours(hours) + Environment.NewLine;
                result += _berlinClockConverterHelper.ChangeHoursIntoBerlinClockOneHours(hours) + Environment.NewLine;
            }

            return result;
        }

        public string GetMinutes(string time)
        {
            string result = "";
            int minutes;
            bool successParse = int.TryParse(_stringTime.GetMinutesFromTime(time), out minutes);
            if (successParse)
            {
                result = _berlinClockConverterHelper.ChangeMinutesIntoBerlinClockFiveMinutes(minutes) + Environment.NewLine;
                result += _berlinClockConverterHelper.ChangeMinutesIntoBerlinClockOneMinutes(minutes);
            }

            return result;
        }

        public string GetSecondState(string time)
        {
            string result = "";
            int seconds;
            bool successParse = int.TryParse(_stringTime.GetMinutesFromTime(time), out seconds);
            if (successParse)
            {
                result = _berlinClockConverterHelper.ChangeSecondsIntoSecondState(seconds) + Environment.NewLine;
            }

            return result;
        }
  
    }
}

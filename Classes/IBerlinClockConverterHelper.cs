using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BerlinClock.Classes
{
    public interface IBerlinClockConverterHelper
    {

        string ChangeHoursIntoBerlinClockFiveHours(int hours);

        string ChangeHoursIntoBerlinClockOneHours(int hours);
        string ChangeMinutesIntoBerlinClockOneMinutes(int minutes);
        string ChangeMinutesIntoBerlinClockFiveMinutes(int minutes);
        string ChangeSecondsIntoSecondState(int seconds);
    }
}

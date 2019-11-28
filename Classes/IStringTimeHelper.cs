using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BerlinClock.Classes
{
    public interface IStringTimeHelper
    {
        string GetHoursFromTime(string time);
        string GetMinutesFromTime(string time);
        string GetSecondsFromTime(string time);

    }
}

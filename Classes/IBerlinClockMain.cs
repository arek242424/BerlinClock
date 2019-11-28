using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BerlinClock.Classes
{
    public interface IBerlinClockMain
    {


        string GetHours(string time);

        string GetMinutes(string time);

        string GetFullTime(string time);




    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BerlinClock.Classes
{
    public class BerlinClockConverterHelper : IBerlinClockConverterHelper
    {
        private const string YELLOW_LIGHT = "Y";
        private const string RED_LIGHT = "R";
        private const string NONE = "O";


        public string ChangeMinutesIntoBerlinClockFiveMinutes(int minutes)
        {
            StringBuilder berlinClockMinutes = new StringBuilder(11);
            int fiveMinutes = minutes / 5;

            for(int i = 0; i < fiveMinutes; i++)
            {
                if (IsQuarter(i + 1))
                    berlinClockMinutes.Append(RED_LIGHT);
                else
                    berlinClockMinutes.Append(YELLOW_LIGHT);
            }

            FillWithDefaultValue(berlinClockMinutes);

            return berlinClockMinutes.ToString();

        }

        public string ChangeMinutesIntoBerlinClockOneMinutes(int minutes)
        {
            StringBuilder berlinClockMinutes = new StringBuilder(4);
            int oneMinutes = minutes % 5;

            for (int i = 0; i < oneMinutes; i++)
            {
                berlinClockMinutes.Append(YELLOW_LIGHT);
            }

            FillWithDefaultValue(berlinClockMinutes);

            return berlinClockMinutes.ToString(); ;
        }

        public string ChangeHoursIntoBerlinClockFiveHours(int hours)
        {
            StringBuilder berlinClockHours = new StringBuilder(4);
            int fiveHours = hours / 5;

            for (int i = 0; i < fiveHours; i++)
            {
                berlinClockHours.Append(RED_LIGHT);
            }

            FillWithDefaultValue(berlinClockHours);

            return berlinClockHours.ToString(); ;
        }

        public  string ChangeHoursIntoBerlinClockOneHours(int hours)
        {
            StringBuilder berlinClockHours = new StringBuilder(4);
            int oneHours = hours % 5;

            for (int i = 0; i < oneHours; i++)
            {
                berlinClockHours.Append(RED_LIGHT);
            }

            FillWithDefaultValue(berlinClockHours);

            return berlinClockHours.ToString(); ;
        }

        public string ChangeSecondsIntoSecondState(int seconds)
        {
            if (seconds % 2 == 0)
                return YELLOW_LIGHT;

            return NONE;
        }


        private bool IsQuarter(int howManyFiveMinutes)
        {
            return howManyFiveMinutes % 3 == 0;
        }

        private void FillWithDefaultValue(StringBuilder berlinClockFormat)
        {
           int k = berlinClockFormat.Capacity - berlinClockFormat.Length;

           for (int i = 0; i < k; i++)
           {
                berlinClockFormat.Append(NONE);
           }
           
        }
    
    }
}

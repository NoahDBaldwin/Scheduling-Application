using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchedulingApplication
{
    internal class TimeConversion
    {
        // Add a 0 to the beginning if a number is less than 10.
        public static string ConvertTime(int time)
        {
            string stTime = "";
            if (time < 10)
            {
                stTime = "0" + time;
            }
            else
            {
                stTime = time.ToString();
            }
            return stTime;
        }


        // Convert the C# datetime to a string in MySql datetime format.
        public static string ToSqlDateTime(DateTime timeToChange, int timeChange)
        {
            
            // Add the minutes for the new time.
            if (timeChange > 0)
            {
                timeToChange = timeToChange.AddMinutes(timeChange);
            }
            
            // Convert each part into proper format
            string year = timeToChange.Year.ToString();
            string day = ConvertTime(timeToChange.Day);
            string month = ConvertTime(timeToChange.Month);
            string hour = ConvertTime(timeToChange.Hour);
            string minute = ConvertTime(timeToChange.Minute);
            string second = ConvertTime(timeToChange.Second);

            // Put the string together in SQL format then return
            string mySqlDateTime = $"{year}-{month}-{day} {hour}:{minute}:{second}";
            return mySqlDateTime;
        }


        public static int GetLength(string apptLength)
        {
            if (apptLength == "30 Minutes")
            {
                return 30;
            }
            else if (apptLength == "1 Hour")
            {
                return 60;
            }
            else
            {
                return 90;
            }
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XMLWeather
{
    public class Day
    {
        public string date, currentTemp, currentTime, condition, location, tempLow, tempHigh,
            windSpeed, windDirection, precipitation, visibility, humidity, conditionNum;

        public int condNum;

        public Day()
        {
            date = currentTemp = currentTime = condition = location = tempLow = tempHigh =
                    windSpeed = windDirection = precipitation = visibility = humidity = conditionNum + "";
        }
    }
}

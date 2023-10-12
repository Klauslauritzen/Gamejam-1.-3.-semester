using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace SurvivalGame.Model
{
    public enum WeatherCondition
    {
        Rain,
        Cloudy,
        Sunny,
        Thunderstorm
    }
    public static class DayStatusModel
    {
        public static int DaysPassed { get; set; }
        public static WeatherCondition Weather { get; set; }
        
        static DayStatusModel() 
        {
            DaysPassed = 0;
            Weather = WeatherCondition.Sunny;
        }

    }


}

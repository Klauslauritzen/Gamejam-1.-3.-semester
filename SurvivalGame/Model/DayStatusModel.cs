﻿using System;
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
    public class DayStatusModel
    {
        public int DaysPassed { get; set; }
        public WeatherCondition Weather { get; set; }
        
        public DayStatusModel() 
        {
            DaysPassed = 0;
            Weather = Weather;
        }

    }


}

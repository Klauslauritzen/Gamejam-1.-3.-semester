﻿using SurvivalGame.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurvivalGame.Controller
{
    public class DayController
    {
        private static Random random = new Random();
        public static WeatherCondition ChanceWeatherOfTheDay()
        {
            int randomNumber = random.Next(1, 101); // Generer et tal mellem 1 og 100

            if (randomNumber <= 30)
                return WeatherCondition.Sunny;
            else if (randomNumber <= 60)
                return WeatherCondition.Rain;
            else if (randomNumber <= 90)
                return WeatherCondition.Cloudy;
            else
                return WeatherCondition.Thunderstorm;
        }

        public static void UpdateDaysPassed()
        {
            DayStatusModel.DaysPassed += 1;
        }
        public static string DayStatus()
        {
            return $"You are now on day {DayStatusModel.DaysPassed}\n" +
                   $"The weather will be {DayStatusModel.Weather}";
        }

    }
}

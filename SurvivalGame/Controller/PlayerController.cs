using SurvivalGame.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurvivalGame.Controller
{

    public class PlayerController
    {
        PlayerModel player = new PlayerModel();
        public void Eat(PlayerModel player)
        {
            player.Time -= 1;
            if (player.Hunger >= 100)
            {
                player.Hunger -= 5;
                player.Energy -= 10;
                Console.WriteLine("You ate WAY too much and puked a little in your mouth");
                Console.WriteLine("-5 hunger \n-10 to energy");
            }
            else
                Console.WriteLine("You ate, that gave you 5+ to Hunger and took 5 energy away");
                player.Energy -= 5;
                player.Hunger += 5;
        }
        public void Sleep(PlayerModel player)
        {
            if (player.Energy >= 100)
            {
                Console.WriteLine("Nice try buddy, you cant be sleeping all day");
            }
            else
            {               
                player.Energy += 40;
                player.Hunger -= 10;
                player.Time = 10;
                DayStatusModel.DaysPassed += 1;
                Console.WriteLine("You went sleep.... zZz ... and feel rested and ready make something out of the day!");
                Thread.Sleep(500);
                Console.Write("zZz...");
                Thread.Sleep(500);
                Console.Write("zZz..."); 
                Thread.Sleep(750);
                Console.WriteLine("Z.z.z.");
                DayStatusModel.Weather = DayController.ChanceWeatherOfTheDay();
                Console.WriteLine(DayController.DayStatus());
                //Console.WriteLine($"You are now on day {dayStatus.DaysPassed}\n" +
                //                  $"it looks like the weather will be {dayStatus.Weather}");


                if (player.Energy >= 100)
                { player.Energy = 100; }
            }
        }
        public void WasteTime(PlayerModel player)
        {
            player.Hunger -= 5;
            player.Time -= 1;
        }

        public void LookForFood(PlayerModel player)
        {
            player.Items.Add(new FoodModel("Rotten Apple", ItemType.Food, ItemQuality.Poor, 5));
        }
        public void LookInInventory(PlayerModel player)
        {
            int count = 0;
            string itemName = "";
            foreach (ItemModel item in player.Items)
            {
                if (item.Type == ItemType.Food)
                {
                    itemName = item.Name;
                    count++; 
                }
            }
                Console.WriteLine($"{count} x {itemName}");     
        }
    }
}

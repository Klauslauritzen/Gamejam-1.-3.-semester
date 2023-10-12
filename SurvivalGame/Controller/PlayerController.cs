using SurvivalGame.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurvivalGame.Controller
{

    public class PlayerController
    {
    DayStatusModel dayStatus = new DayStatusModel();
        PlayerModel player = new PlayerModel();
        public void Eat(PlayerModel player)
        {
            player.Energy -= 5;
            player.Hunger += 5;
            player.Time -= 1;
            if (player.Hunger >= 100)
            {
                player.Hunger = 100;
                Console.WriteLine("You ate, and can't be more full");
            }
            else
                Console.WriteLine("You ate, that gave you 5+ to Hunger and took 5 energy away");
        }
        public void Sleep(PlayerModel player)
        {
            if (player.Energy >= 100)
            {
                Console.WriteLine("Nice try boddy, you cant be sleeping all day");
            }
            else
            {               
                player.Energy += 40;
                player.Hunger -= 10;
                player.Time = 10;
                dayStatus.DaysPassed += 1;
                Console.WriteLine("You went sleep.... zZz ... and feel rested and ready make something out of the day!");
                Thread.Sleep(500);
                Console.Write("zZz...");
                Thread.Sleep(500);
                Console.Write("zZz..."); 
                Thread.Sleep(750);
                Console.WriteLine("Z.z.z.");
                Console.WriteLine(DayController.DayStatus(dayStatus));
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

        public void LookForFood(ItemModel item, PlayerModel player)
        {
            player.Items.Add();
        }
    }
}

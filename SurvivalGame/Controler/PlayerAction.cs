using SurvivalGame.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurvivalGame.Controler
{
    public class PlayerAction
    {
        public void Eat(Player player)
        {
            player.Energy -= 5;
            player.Hunger += 5;
            player.Time -= 1;
            if (player.Hunger >= 100)
            {
                player.Hunger = 100;
                Console.WriteLine("You ate, and cant bee more full");
            }
            else
                Console.WriteLine("You ate, that gave you 5+ to Hunger and took 5 energy away");
        }
        public void Sleep(Player player)
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
                Console.WriteLine("You went sleep, and feel rested and ready make something out of the day!");

                if (player.Energy >= 100)
                { player.Energy = 100; }
            }
        }
        public void WasteTime(Player player)
        {
            player.Hunger -= 5;
            player.Time -= 1;
        }


    }
}

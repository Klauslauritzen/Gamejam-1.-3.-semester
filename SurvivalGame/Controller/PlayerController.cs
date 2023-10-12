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
        public void Eat(PlayerModel player)
        {
            LookInInventory(player.Items); // Vis inventory

            Console.WriteLine("Choose the food you want to eat (enter a number):");
            string input = Console.ReadLine();

            if (int.TryParse(input, out int choice) && choice >= 1 && choice <= player.Items.Count)
            {
                int itemIndex = choice - 1;

                if (player.Items[itemIndex] is FoodModel food)
                {
                    player.Hunger += food.HungerRestored;

                    Console.WriteLine($"You ate {food.Name}, which restored {food.HungerRestored} to your hunger.");
                    player.Items.RemoveAt(itemIndex); // Fjern den spiste mad fra inventory
                }
                else
                {
                    Console.WriteLine("Invalid choice. Try again.");
                }
            }
            else
            {
                Console.WriteLine("Invalid choice. Try again.");
            }
        }

        //public void Eat(PlayerModel player)
        //{
        //    player.Time -= 1;
        //    if (player.Hunger >= 100)
        //    {
        //        player.Hunger -= 5;
        //        player.Energy -= 10;
        //        Console.WriteLine("You ate WAY too much and puked a little in your mouth");
        //        Console.WriteLine("-5 hunger \n-10 to energy");
        //    }
        //    else
        //    {
        //        Console.WriteLine("You ate, that gave you 5+ to Hunger and took 5 energy away");
        //        player.Energy -= 5;
        //        player.Hunger += 5;
        //    }
        //}
        public void Sleep(PlayerModel player)
        {
            if (player.Energy >= 100)
            {
                Console.WriteLine("Nice try buddy, you cant be sleeping all day");
            }
            else if (player.Time <= 0)
            {
                player.Energy += 40;
                player.Hunger -= 10;
                player.Time = 8;
                DayStatusModel.DaysPassed += 1;
                Console.WriteLine("You went sleep.... zZz ...");
                Thread.Sleep(500);
                Console.Write("zZz...");
                Thread.Sleep(500);
                Console.Write("zZz...");
                Thread.Sleep(750);
                Console.WriteLine("Z.z.z.");
                Console.WriteLine("You woke up, but you oversleept a little, and have a little less time for the day");
                DayStatusModel.Weather = DayController.ChanceWeatherOfTheDay();
                Console.WriteLine(DayController.DayStatus());
            }
            else
            {
                player.Energy += 40;
                player.Hunger -= 10;
                player.Time = 10;
                DayStatusModel.DaysPassed += 1;
                Console.WriteLine("You went sleep.... zZz ...");
                Thread.Sleep(500);
                Console.Write("zZz...");
                Thread.Sleep(500);
                Console.Write("zZz...");
                Thread.Sleep(750);
                Console.WriteLine("Z.z.z.");
                Console.WriteLine("You woke up and feel rested and ready make something out of the day!");
                DayStatusModel.Weather = DayController.ChanceWeatherOfTheDay();
                Console.WriteLine(DayController.DayStatus());



                if (player.Energy >= 100)
                { player.Energy = 100; }
            }
        }
        public void WasteTime(PlayerModel player)
        {
            player.Hunger -= 5;
            player.Time -= 1;
            if(DayStatusModel.Weather == WeatherCondition.Sunny)
            {
                player.Energy += 10;
                Console.WriteLine("You enjoy the the sun, the heat is perfect at you feel like you have more Energy");
            }
            else if (DayStatusModel.Weather == WeatherCondition.Cloudy)
            {
                player.Energy += 5;
                Console.WriteLine("The cloudy weather keeps you comfortable.");
            }
            else if (DayStatusModel.Weather == WeatherCondition.Rain)
            {
                player.Energy -= 5;
                Console.WriteLine("The rain drains your energy. You feel a bit tired.");
            }
            else if (DayStatusModel.Weather == WeatherCondition.Thunderstorm)
            {
                player.Energy -= 15;
                Console.WriteLine("The thunderstorm is frightening and exhausting. You lose a significant amount of energy.");
            }
        }

        public void LookForFood(PlayerModel player)
        {
            Random random = new Random();
            int randomNumber = random.Next(1, 101); // Generer et tal mellem 1 og 100
            player.Energy -= 20;
            player.Time -= 2;
            player.Hunger -= 5;

            if (randomNumber <= 20)
            {
                player.Items.Add(new FoodModel("Rotten Apple", ItemType.Food, ItemQuality.Poor, 5));
            }
            else if (randomNumber <= 80)
            {
                player.Items.Add(new FoodModel("Decent Apple", ItemType.Food, ItemQuality.Good, 10));
            }
            else
            {
                player.Items.Add(new FoodModel("Delicious Apple", ItemType.Food, ItemQuality.Excellent, 15));
            }

            var items = player.Items;
            Console.WriteLine($"After walking around for a LOOOOOOOONG 1 time you found a {items[items.Count - 1].Name} ");
            Console.WriteLine(Program.split);

        }

        public void LookInInventory(List<ItemModel> items)
        {
            Console.WriteLine(Program.split);
            Console.WriteLine("This is your Inventory");

            for (int i = 0; i < items.Count; i++)
            {
                string itemName = items[i].Name;
                Console.WriteLine($"{i + 1}. {itemName}");
            }

            Console.WriteLine(Program.split);
        }

        public void CheckGameState(PlayerModel player)
        {
            if(player.Hunger >= 100)
            {
                player.Hunger = 100;
            }
            if (player.Energy >= 100)
            {
                player.Energy = 100;
            }
            if(player.Energy <= 0)
            {
                Console.WriteLine("You are out of energy, you feel dizzy, and you start to sense the world spinning around you.");
                Thread.Sleep(1500);
                Console.WriteLine(".........");
                Thread.Sleep(1000);
                Console.WriteLine("Suddenly, it darkens before your eyes");
                Thread.Sleep(1000);
                Console.WriteLine("..........");
                Thread.Sleep(2000);
                Console.WriteLine("You awaken on the, hard ground, aching from your rough slumber. A sense of gnawing hunger begins to slowly encroach upon you.");
                player.Energy += 15;
                player.Hunger -= 30;
                player.Time -= 3;
            }
            if(player.Time <= -1)
            {
                Console.WriteLine(Program.split);
                Console.WriteLine("You reached the end of the day, you have to go seek some shelter");
                player.Energy -= 10;
                Sleep(player);
                Console.WriteLine(Program.split);
                Console.ReadLine();
                if (player.Energy >= 100)
                {
                    player.Energy = 100;
                }
            }
            if (player.Hunger <= 0)
            {
                player.Alive = false;
                Console.WriteLine("Game Over \nYou Died");
                Console.WriteLine(Program.split);
            }
        }
    }
}

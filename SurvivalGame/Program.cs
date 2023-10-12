using SurvivalGame.Controller;
using SurvivalGame.Model;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using System.Xml.Linq;

namespace SurvivalGame
{
    public class Program
    {
        public static string split = "---------------------------------------------";
        static void Main(string[] args)
        {
            PlayerModel player = new PlayerModel();
            PlayerController action = new PlayerController();
            DayController dayController = new DayController();


            Console.WriteLine("Welcome to Island Survival!");
            do

            {
                Console.WriteLine(split);
                Console.WriteLine(player);
                Console.WriteLine($"Day {DayStatusModel.DaysPassed}, Weather: {DayStatusModel.Weather}");
                Console.WriteLine(split +"\nChoose your next move\n" + split);
                Console.WriteLine("Press 1 to eat");
                Console.WriteLine("press 2 to sleep");
                Console.WriteLine("Press 3 to waste some time");
                Console.WriteLine("Press 4 to look for food");
                Console.WriteLine("Press 5 to look in inventory");

                string input = "";
                int playerInput;
                while (!int.TryParse(input, out playerInput))
                {
                    Console.Write("your choice: ");
                    input = Console.ReadLine();
                }
                Console.WriteLine(split);
                switch (playerInput)
                {
                    case 1:
                        action.Eat(player);
                        break;
                    case 2:
                        action.Sleep(player);
                        break;
                    case 3:
                        action.WasteTime(player);
                        break;
                    case 4:
                        action.LookForFood(player);
                        break;
                    case 5:
                        action.LookInInventory(player.Items);
                        break;

                    default:
                        Console.WriteLine("Invalid option. Try again.");
                        break;
                }
                Console.WriteLine("Proceed to next action");
                Console.ReadLine();

                action.CheckGameState(player);
                Console.Clear();


            }
            while (player.Alive == true);
        }
    }
}
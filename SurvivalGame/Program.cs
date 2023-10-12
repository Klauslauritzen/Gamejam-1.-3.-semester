using SurvivalGame.Controller;
using SurvivalGame.Model;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace SurvivalGame
{
    public class Program
    {
        static void Main(string[] args)
        {
            PlayerModel player = new PlayerModel();
            PlayerController action = new PlayerController();
            DayController dayController = new DayController();


            Console.WriteLine("Welcome to Island Survival!");
            do

            {
                Console.WriteLine("--------------------------------------------");
                Console.WriteLine(player);
                Console.WriteLine($"Day {DayStatusModel.DaysPassed}, Weather: {DayStatusModel.Weather}");
                Console.WriteLine("--------------------------------------------\nChoose your next move\n--------------------------------------------");
                Console.WriteLine("press 1 to eat");
                Console.WriteLine("press 2 to sleep");
                Console.WriteLine("press 3 to waste some time");
                Console.WriteLine("Press 4 to look for food");

                string input = "";
                int playerInput;
                while (!int.TryParse(input, out playerInput))
                {
                    Console.Write("your choose: ");
                    input = Console.ReadLine();
                }

                switch (playerInput)
                {
                    case 1:
                        action.Eat(player);
                        break;
                    case 2:
                        action.Sleep(player);
                        //dayStatus.DaysPassed += 1;
                        break;
                    case 3:
                        action.WasteTime(player);
                        break;
                    case 4:
                        action.LookForFood(player);
                        var items = player.Items;
                        Console.WriteLine($"After walking around for a LOOOOOOOONG 1 time you found a {items[items.Count-1].Name} ");
                        break;
                    case 5:
                        action.LookInInventory(player);
                        break;

                    default:
                        Console.WriteLine("Invalid option. Try again.");
                        break;

                }
                Console.WriteLine("Proceed to next action");
                Console.ReadLine();

                Console.Clear();


            }
            while (player.Alive == true);
        }
    }
}
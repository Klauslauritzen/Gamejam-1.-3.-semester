using SurvivalGame.Controller;
using SurvivalGame.Model;

namespace SurvivalGame
{
    public class Program
    {
        static void Main(string[] args)
        {
            PlayerModel player = new PlayerModel();
            PlayerController action = new PlayerController();
            DayController dayController = new DayController();
            DayStatusModel dayStatus = new DayStatusModel();


            Console.WriteLine("Welcome to Island Survival!");
            do

            {
                Console.WriteLine("--------------------------------------------");
                Console.WriteLine(player);
                Console.WriteLine($"Day {dayStatus.DaysPassed}, Weather: {dayStatus.Weather}");
                Console.WriteLine("--------------------------------------------\nChoose your next move\n--------------------------------------------");
                Console.WriteLine("press 1 to eat");
                Console.WriteLine("press 2 to sleep");
                Console.WriteLine("press 3 to waste some time");

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
                        dayStatus.Weather = DayController.ChanceWeatherOfTheDay();
                        break;
                    case 3:
                        action.WasteTime(player);
                        break;

                    default:
                        Console.WriteLine("Invalid option. Try again.");
                        break;

                }
                Console.WriteLine("Proceed to next action");
                Console.ReadLine();
                        dayStatus.Weather = dayStatus.Weather;
                
                Console.Clear();


            }
            while (player.Alive == true);
        }
    }
}
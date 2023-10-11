using SurvivalGame.Controler;
using SurvivalGame.Model;

namespace SurvivalGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();
            DayStatus dayStatus = new DayStatus();
            PlayerAction action = new PlayerAction();
            DayController dayController = new DayController();


            Console.WriteLine("Welcome to Island Survival!");
            do

            {
                Console.WriteLine(player);
                Console.WriteLine("press 1 to eat");
                Console.WriteLine("press 2 to sleep");
                string input = "";
                int playerInput;
                while (!int.TryParse(input, out playerInput))
                {
                    input = Console.ReadLine();
                }

                switch (playerInput)
                {
                    case 1:
                        action.Eat(player);
                        break;
                    case 2:
                        action.Sleep(player);
                        DayController.ChanceWeatherOfTheDay();
                        DayController.UpdateDaysPassed(dayStatus);
                        Console.WriteLine(dayStatus);
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
                
                Console.Clear();


            }
            while (player.Alive == true);
        }
    }
}
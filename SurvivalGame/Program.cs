namespace SurvivalGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Island Survival!");
            Player player = new Player();

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
                        player.Eat();
                        break;
                    case 2:
                        player.Sleep();
                        break;
                    default:
                        Console.WriteLine("idiot, try again!!");
                        continue;

                }
                Console.WriteLine("Proceed to next action");
                Console.ReadLine();
                
                Console.Clear();


            }
            while (player.Alive == true);
        }
    }
}
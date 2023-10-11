namespace SurvivalGame;

public class Player
{
    private int stamina {  get; set; }
    private int daysPassed { get; set; }

    public Player ()
    {
        hunger = 100;
        stamina = 100; 
        daysPassed = 0;
        Alive = true;
    }

    public void Eat()
    {
        stamina -= 5;
        hunger += 5;
    }
    public void Sleep()
    {
        stamina += 5;
        hunger -= 5;
    }

    public override string ToString()
    {
        return $"Your hunger is {hunger} \nYour stamina is {stamina} \nDays passed {daysPassed}";
    }
}

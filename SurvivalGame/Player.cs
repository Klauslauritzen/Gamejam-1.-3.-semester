namespace SurvivalGame;

public class Player
{
    private int energy {  get; set; }
    private int daysPassed { get; set; }
    public bool Alive { get; set; }
    private int time {  get; set; }
    private int hunger { get; set; }

    public Player ()
    {
        hunger = 100;
        energy = 100; 
        daysPassed = 0;
        Alive = true;
    }

    public void Eat()
    {
        energy -= 5;
        hunger += 5;
    }
    public void Sleep()
    {
        energy += 5;
        hunger -= 5;
    }

    public override string ToString()
    {
        return $"Your hunger is {hunger} \nYour stamina is {energy} \nDays passed {daysPassed}";
    }
}

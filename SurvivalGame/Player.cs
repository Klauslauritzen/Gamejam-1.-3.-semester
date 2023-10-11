namespace SurvivalGame;

public class Player
{
<<<<<<< HEAD
    public bool Alive { get; set; }
    private int hunger {  get; set; }
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
=======
    private Int32 daysPassed;
    private Boolean isAlive;
    public Int32 Hunger { get; set; }
    public Int32 Stamina { get; set; }
    
}
>>>>>>> e83321531063912c62d4e6cdcd904dd4724caed3

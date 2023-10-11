namespace SurvivalGame.Model;

public class Player
{
    public bool Alive { get; set; }
    public int Hunger { get; set; }
    public int Energy { get; set; }
    public int Time { get; set; }

    public Player()
    {
        Hunger = 100;
        Energy = 100;
        Time = 10;
        Alive = true;
    }

    public override string ToString()
    {
        return $"Your hunger is {Hunger} \nYour Energy is {Energy}\n You have {Time}/10 time left";
    }
}
    
    


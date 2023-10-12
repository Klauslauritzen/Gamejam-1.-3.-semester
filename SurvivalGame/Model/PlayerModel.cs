namespace SurvivalGame.Model;

public class PlayerModel
{
    public bool Alive { get; set; }
    public int Hunger { get; set; }
    public int Energy { get; set; }
    public int Time { get; set; }
    public List<ItemModel> Items { get; set; }

    public PlayerModel()
    {
        Hunger = 100;
        Energy = 100;
        Time = 10;
        Alive = true;
        Items = new List<ItemModel>();
    }

    public override string ToString()
    {
        return $"Your hunger is {Hunger} \n" +
            $"Your Energy is {Energy}\n" +
            $"You have {Time}/10 time left";
    }

}
    
    


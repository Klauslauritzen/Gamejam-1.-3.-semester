namespace SurvivalGame
{
    internal class Item
    {
        public ItemType Type {  get; set; }
        public Quality Quality { get; set; }
        public string Name { get; set; }

        
    }

    public enum ItemType
    {
        Food,
        Material,
        Tool
    }
    public enum Quality
    {
        Low,
        Medium,
        High
    }
}

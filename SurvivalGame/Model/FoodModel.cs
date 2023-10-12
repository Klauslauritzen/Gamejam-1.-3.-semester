using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurvivalGame.Model
{
    public class FoodModel : ItemModel
    {
        public int HungerRestored { get; set; }
        public FoodModel(string Name, ItemType Type, ItemQuality Quality, int HungerRestored)
        {
            this.Name = Name;
            this.Type = Type;
            this.Quality = Quality;
            this.HungerRestored = HungerRestored;
        }
        //public FoodModel ApplePoor = new FoodModel("Rotten Apple", ItemType.Food, ItemQuality.Poor, 5);
        //public FoodModel AppleGood = new FoodModel("Decent Apple", ItemType.Food, ItemQuality.Good, 10);
        //public FoodModel AppleExcellent = new FoodModel("Delicious Apple", ItemType.Food, ItemQuality.Excellent, 15);

    }
}
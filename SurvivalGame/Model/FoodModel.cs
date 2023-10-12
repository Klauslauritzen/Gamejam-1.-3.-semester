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
    }
}
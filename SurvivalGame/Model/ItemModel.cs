using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace SurvivalGame.Model
{
    public class ItemModel
    {
        public string Name { get; set; }
        public ItemType Type { get; set; }
        public ItemQuality Quality { get; set; }    
    }
    public enum ItemType
    {
        Food,
        Material,
        Tool
    }
    public enum ItemQuality
    {
        Poor,
        Good,
        Excellent
    }
}

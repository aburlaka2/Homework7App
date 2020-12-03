using System;
using System.Collections.Generic;
using System.Text;

namespace Homework7App.Equipment.Armors
{
    class SteelPlateArmor:Armor
    {
        public int defence { get; set; }
        public SteelPlateArmor()
        {
            name = "Steel Plate Armor";
            weight = 15;
            price = 120;
            rarity = 8;
            defence = 8;
        }
    }
}

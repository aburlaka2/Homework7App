using System;
using System.Collections.Generic;
using System.Text;

namespace Homework7App.Equipment.Armors
{
    class LeatherArmor:Armor
    {
        public int defence { get; set; }
        public LeatherArmor()
        {
            name = "Leather Armor";
            weight = 5;
            price = 20;
            rarity = 1;
            defence = 1;
        }
    }
}

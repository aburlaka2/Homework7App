using System;
using System.Collections.Generic;
using System.Text;

namespace Homework7App.Equipment.Armors
{
    class BronzeArmor:Armor
    {
        public int defence { get; set; }
        public BronzeArmor()
        {
            name = "Bronze Armor";
            weight = 10;
            price = 50;
            rarity = 4;
            defence = 4;
        }
    }
}

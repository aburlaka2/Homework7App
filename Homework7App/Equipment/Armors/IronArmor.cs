using System;
using System.Collections.Generic;
using System.Text;

namespace Homework7App.Equipment.Armors
{
    class IronArmor:Armor
    {
        public int defence { get; set; }
        public IronArmor()
        {
            name = "Iron Armor";
            weight = 15;
            price = 80;
            rarity = 6;
            defence = 6;
        }
    }
}

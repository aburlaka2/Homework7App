using System;
using System.Collections.Generic;
using System.Text;

namespace Homework7App.Equipment.Armors
{
    class CopperArmor:Armor
    {
        public int defence { get; set; }
        public CopperArmor()
        {
            name = "Copper Armor";
            weight = 10;
            price = 40;
            rarity = 2;
            defence = 3;
        }
    }
}

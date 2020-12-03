using System;
using System.Collections.Generic;
using System.Text;

namespace Homework7App.Equipment.Armors
{
    class MithrilArmor:Armor
    {
        public int defence { get; set; }
        public MithrilArmor()
        {
            name = "Mithril Armor";
            weight = 12;
            price = 200;
            rarity = 9;
            defence = 9;
        }
    }
}

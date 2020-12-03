using System;
using System.Collections.Generic;
using System.Text;

namespace Homework7App.Equipment.Shields
{
    class SteelShield:Shield
    {
        public int defence { get; set; }
        public SteelShield()
        {
            name = "Steel Shield";
            weight = 10;
            price = 60;
            rarity = 7;
            defence = 7;
        }
    }
}

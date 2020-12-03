using System;
using System.Collections.Generic;
using System.Text;

namespace Homework7App.Equipment.Shields
{
    class WoodenShield:Shield
    {
        public int defence { get; set; }
        public WoodenShield()
        {
            name = "Wooden Shield";
            weight = 3;
            price = 10;
            rarity = 1;
            defence = 1;
        }
    }
}

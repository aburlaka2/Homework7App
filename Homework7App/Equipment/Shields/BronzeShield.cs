using System;
using System.Collections.Generic;
using System.Text;

namespace Homework7App.Equipment.Shields
{
    class BronzeShield:Shield
    {
        public int defence { get; set; }
        public BronzeShield()
        {
            name = "Bronze Shield";
            weight = 6;
            price = 25;
            rarity = 3;
            defence = 3;
        }
    }
}

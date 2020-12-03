using System;
using System.Collections.Generic;
using System.Text;

namespace Homework7App.Equipment.Shields
{
    class IronShield:Shield
    {
        public int defence { get; set; }
        public IronShield()
        {
            name = "Iron Shield";
            weight = 9;
            price = 40;
            rarity = 5;
            defence = 5;
        }
    }
}

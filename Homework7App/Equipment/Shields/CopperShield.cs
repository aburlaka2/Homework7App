using System;
using System.Collections.Generic;
using System.Text;

namespace Homework7App.Equipment.Shields
{
    class CopperShield:Shield
    {
        public int defence { get; set; }
        public CopperShield()
        {
            name = "Copper Helmet";
            weight = 6;
            price = 20;
            rarity = 2;
            defence = 2;
        }
    }
}

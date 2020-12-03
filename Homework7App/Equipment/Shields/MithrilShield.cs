using System;
using System.Collections.Generic;
using System.Text;

namespace Homework7App.Equipment.Shields
{
    class MithrilShield:Shield
    {
        public int defence { get; set; }
        public MithrilShield()
        {
            name = "Mithril Helmet";
            weight = 6;
            price = 80;
            rarity = 8;
            defence = 6;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Homework7App.Equipment.Helmets
{
    class SteelHelmet:Helmet
    {
        public int defence { get; set; }
        public SteelHelmet()
        {
            name = "Steel Helmet";
            weight = 8;
            price = 50;
            rarity = 6;
            defence = 5;
        }
    }
}

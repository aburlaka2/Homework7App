using System;
using System.Collections.Generic;
using System.Text;

namespace Homework7App.Equipment.Helmets
{
    public
    class BronzeHelmet:Helmet
    {
        public int defence { get; set; }
        public BronzeHelmet()
        {
            name = "Bronze Helmet";
            weight = 4;
            price = 20;
            rarity = 3;
            defence = 3;
        }
    }
}

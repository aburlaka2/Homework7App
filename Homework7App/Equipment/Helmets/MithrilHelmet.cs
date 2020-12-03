using System;
using System.Collections.Generic;
using System.Text;

namespace Homework7App.Equipment.Helmets
{
    class MithrilHelmet:Helmet
    {
        public int defence { get; set; }
        public MithrilHelmet()
        {
            name = "Mithril Helmet";
            weight = 6;
            price = 80;
            rarity = 8;
            defence = 6;
        }
    }
}

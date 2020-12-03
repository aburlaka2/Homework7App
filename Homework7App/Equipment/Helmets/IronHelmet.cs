using System;
using System.Collections.Generic;
using System.Text;

namespace Homework7App.Equipment.Helmets
{
    class IronHelmet:Helmet
    {
        public int defence { get; set; }
        public IronHelmet()
        {
            name = "Iron Helmet";
            weight = 7;
            price = 30;
            rarity = 4;
            defence = 4;
        }
    }
}

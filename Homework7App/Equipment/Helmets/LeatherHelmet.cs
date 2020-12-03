using System;
using System.Collections.Generic;
using System.Text;

namespace Homework7App.Equipment.Helmets
{
    class LeatherHelmet:Helmet
    {
        public int defence { get; set; }
        public LeatherHelmet()
        {
            name = "Lether Helmet";
            weight = 2;
            price = 5;
            rarity = 1;
            defence = 1;
        }
    }
}

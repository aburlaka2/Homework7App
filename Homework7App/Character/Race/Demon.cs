using System;
using System.Collections.Generic;
using System.Text;

namespace Homework7App.Character.Race
{
    class Demon:Race, INotPlayble
    {
        public Demon()
        {
            CharacterRace = "Demon";
            RaceHealth = 12;
            RaceMana = 15;
            RaceStreghth = 10;
            RaceAgilty = 8;
            RaceIntelect = 8;
        }
    }
}

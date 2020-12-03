using System;
using System.Collections.Generic;
using System.Text;

namespace Homework7App.Character.Race
{
    class Dwаrf:Race,IPlayble
    {
        public Dwаrf()
        {
            CharacterRace = "Dwarf";
            RaceHealth = 6;
            RaceMana = 4;
            RaceStreghth = 7;
            RaceAgilty = 2;
            RaceIntelect = 2;
        }
    }
}

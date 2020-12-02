using System;
using System.Collections.Generic;
using System.Text;

namespace Homework7App.Character.Race
{
    class Orc:Race,INotPlayble
    {
        public Orc()
        {
            CharacterRace = "Orc";
            RaceHealth = 8;
            RaceMana = 4;
            RaceStreghth = 8;
            RaceAgilty = 4;
            RaceIntelect = 2;
        }
    }
}

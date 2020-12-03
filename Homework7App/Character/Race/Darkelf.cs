using System;
using System.Collections.Generic;
using System.Text;

namespace Homework7App.Character.Race
{
    class Darkelf:Race,INotPlayble
    {
        public Darkelf()
        {
            CharacterRace = "Darkelf";
            RaceHealth = 7;
            RaceMana = 10;
            RaceStreghth = 7;
            RaceAgilty = 8;
            RaceIntelect = 6;
        }
    }
}

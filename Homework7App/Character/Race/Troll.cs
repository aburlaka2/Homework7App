using System;
using System.Collections.Generic;
using System.Text;

namespace Homework7App.Character.Race
{
    class Troll:Race,INotPlayble
    {
        public Troll()
        {
        CharacterRace = "Troll";
        RaceHealth = 15;
        RaceMana = 8;
        RaceStreghth = 12;
        RaceAgilty = 6;
        RaceIntelect = 4;
        }
    }
}

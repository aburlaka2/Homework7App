using System;
using System.Collections.Generic;
using System.Text;

namespace Homework7App.Character.Race
{
    class Human: Race, IPlayble
    {
        public Human()
        {
            CharacterRace = "Human";
            RaceHealth = 15;
            RaceMana = 8;
            RaceStreghth = 12;
            RaceAgilty = 6;
            RaceIntelect = 4;
        }
    }
}

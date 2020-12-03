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
            RaceHealth = 5;
            RaceMana = 5;
            RaceStreghth = 5;
            RaceAgilty = 3;
            RaceIntelect = 3;
        }
    }
}

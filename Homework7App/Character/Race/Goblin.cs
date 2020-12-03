using System;
using System.Collections.Generic;
using System.Text;

namespace Homework7App.Character.Race
{
    class Goblin: Race, INotPlayble
    {
        public Goblin()
        {
            CharacterRace = "Goblin";
            RaceHealth = 6;
            RaceMana = 6;
            RaceStreghth = 5;
            RaceAgilty = 8;
            RaceIntelect = 4;
        }
    }
}

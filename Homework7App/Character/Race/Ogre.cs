using System;
using System.Collections.Generic;
using System.Text;

namespace Homework7App.Character.Race
{
    class Ogre:Race, INotPlayble
    {
        public Ogre()
        {
            CharacterRace = "Ogre";
            RaceHealth = 10;
            RaceMana = 6;
            RaceStreghth = 10;
            RaceAgilty = 5;
            RaceIntelect = 3;
        }
    }
}

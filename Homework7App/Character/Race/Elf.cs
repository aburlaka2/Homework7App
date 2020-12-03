using System;
using System.Collections.Generic;
using System.Text;

namespace Homework7App.Character.Race
{
    class Elf:Race,IPlayble
    {
        public Elf()
        {
            CharacterRace = "Elf";
            RaceHealth = 4;
            RaceMana = 8;
            RaceStreghth = 4;
            RaceAgilty = 4;
            RaceIntelect = 4;
        }
    }
}

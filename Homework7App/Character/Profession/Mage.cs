using System;
using System.Collections.Generic;
using System.Text;

namespace Homework7App.Character.Profession
{
    class Mage:Profession
    {
        public Mage()
        {
            CharacterProfession = "Mage";
            ProfessionHealth = 3;
            ProfessionMana = 5;
            ProfessionStreghth = 1;
            ProfessionAgilty = 1;
            ProfessionIntelect = 5;
        }
    }
}

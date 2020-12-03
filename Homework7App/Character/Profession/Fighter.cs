using System;
using System.Collections.Generic;
using System.Text;

namespace Homework7App.Character.Profession
{
    class Fighter: Profession
    {
        public Fighter()
        {
            CharacterProfession = "Fighter";
            ProfessionHealth = 5;
            ProfessionMana = 1;
            ProfessionStreghth = 7;
            ProfessionAgilty = 3;
            ProfessionIntelect = 1;
        }
    }
}

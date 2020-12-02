using System;
using System.Collections.Generic;
using System.Text;
using Homework7App.Equipment.Abstract;

namespace Homework7App.Equipment
{
    class Shield:Item,IWearable
    {
        public int slot { get; set; }
        public string slotName { get; set; }
        public void WearItem()
        {

        }
    }
}

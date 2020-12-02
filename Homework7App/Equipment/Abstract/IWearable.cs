using System;
using System.Collections.Generic;
using System.Text;

namespace Homework7App.Equipment.Abstract
{
    interface IWearable
    {
        public int slot { get; set; }
        public string slotName { get; set; }
        public void WearItem();
    }
}

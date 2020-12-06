
using System;
using System.Collections.Generic;
using System.Text;
using Homework7App.GameMarket;
using Homework7App;

namespace Homework7App.GameMarket
{
    public class Account
    {
        public User Owner { get; set; }

        public PaymentInfo PaymentInfo { get; set; }
        public Transaction[] PaymentHistory { get; set; }

        public Balance Balance { get; set; }

        public MarketItem[] PurchasedItems { get; }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace MobileApps.Models
{
    public class CreditCard
    {
        public string Number { get; set; }
        public int Year { get; set; }
        public int ExpYear { get; set; }
        public int Month { get; set; }
        public int ExpMonth { get; set; }
        public string Cvc { get; set; }
    }
}

using System;
using System.Collections.Generic;

#nullable disable

namespace KaraokeBar.Models
{
    public partial class Order
    {
        public int OrderId { get; set; }
        public int BillId { get; set; }
        public string User { get; set; }
        public string ServiceId { get; set; }
        public int Quantity { get; set; }
        public int TotalPayment { get; set; }
        public bool Status { get; set; }

        public virtual Service Service { get; set; }
        public virtual Account UserNavigation { get; set; }
    }
}

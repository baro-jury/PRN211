using System;
using System.Collections.Generic;

#nullable disable

namespace KaraokeBar.Models
{
    public partial class Bill
    {
        public int BillId { get; set; }
        public string UserName { get; set; }
        public DateTime OrderDate { get; set; }
        public string PaymentMethod { get; set; }
        public bool Status { get; set; }

        public virtual Account UserNameNavigation { get; set; }
    }
}

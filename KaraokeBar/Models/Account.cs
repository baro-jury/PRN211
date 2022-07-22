using System;
using System.Collections.Generic;

#nullable disable

namespace KaraokeBar.Models
{
    public partial class Account
    {
        public Account()
        {
            Bills = new HashSet<Bill>();
        }

        public string DisplayName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Permission { get; set; }

        public virtual ICollection<Bill> Bills { get; set; }
    }
}

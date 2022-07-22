using System;
using System.Collections.Generic;

#nullable disable

namespace KaraokeBar.Models
{
    public partial class Room
    {
        public int Floor { get; set; }
        public int RoomNumber { get; set; }
        public int Type { get; set; }
        public int Price { get; set; }
        public bool Status { get; set; }

        public virtual TypeOfRoom TypeNavigation { get; set; }
    }
}

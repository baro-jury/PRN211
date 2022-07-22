using System;
using System.Collections.Generic;

#nullable disable

namespace KaraokeBar.Models
{
    public partial class Service
    {
        public string ServiceId { get; set; }
        public int RoomType { get; set; }
        public string ServiceName { get; set; }
        public int Price { get; set; }
        public int Quantity { get; set; }

        public virtual TypeOfRoom RoomTypeNavigation { get; set; }
    }
}

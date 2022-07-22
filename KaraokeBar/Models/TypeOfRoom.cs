using System;
using System.Collections.Generic;

#nullable disable

namespace KaraokeBar.Models
{
    public partial class TypeOfRoom
    {
        public TypeOfRoom()
        {
            Rooms = new HashSet<Room>();
            Services = new HashSet<Service>();
        }

        public int TypeId { get; set; }
        public string TypeName { get; set; }

        public virtual ICollection<Room> Rooms { get; set; }
        public virtual ICollection<Service> Services { get; set; }
    }
}

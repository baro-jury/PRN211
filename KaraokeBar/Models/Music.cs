using System;
using System.Collections.Generic;

#nullable disable

namespace KaraokeBar.Models
{
    public partial class Music
    {
        public string MusicId { get; set; }
        public string AccentedName { get; set; }
        public string Genre { get; set; }
        public string Composer { get; set; }
        public string Singer { get; set; }
        public string Lyric { get; set; }
        public string UnaccentedName { get; set; }
        public string Abbreviation { get; set; }
        public string Link { get; set; }
    }
}

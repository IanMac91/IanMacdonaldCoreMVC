using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace IanMacdonaldCoreMVC.Models
{
    public class Album
    {
        public int AlbumId { get; set; }
        public string AlbumTitle { get; set; }
        public int ArtistId { get; set; }
        public Artist Artist { get; set; }
        public DateTime AlbumReleased { get; set; }
        public virtual List<Song> Songs { get; set; }
    }
}

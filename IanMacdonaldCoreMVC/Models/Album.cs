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
        [Required, MaxLength(20)]
        [Display(Name = "Album")]
        public string AlbumTitle { get; set; }
        public int ArtistId { get; set; }
        public Artist Artist { get; set; }
        [Display(Name = "Released")]
        public DateTime AlbumReleased { get; set; }
        public List<Song> Songs { get; set; }
    }
}

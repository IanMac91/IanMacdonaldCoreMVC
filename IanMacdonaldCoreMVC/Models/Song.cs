using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace IanMacdonaldCoreMVC.Models
{
    public class Song
    {
        public int SongId { get; set; }
        [Display(Name = "Song")]
        [Required, MaxLength(20)]
        public string SongName { get; set; }
        [Display(Name = "Track")]
        public int TrackPosition { get; set; }
        public int AlbumId { get; set; }
        public Album Album { get; set; }
    }
}

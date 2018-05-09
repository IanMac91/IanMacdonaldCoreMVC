using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace IanMacdonaldCoreMVC.Models
{
    public class Artist
    {
        public int ArtistId { get; set; }
        [Display(Name = "Artist")]
        [Required, MaxLength(20)]
        public string ArtistName { get; set; }
        [Required]
        public Genre Genre { get; set; }
        public List<Album> Albums { get; set; }
    }
}

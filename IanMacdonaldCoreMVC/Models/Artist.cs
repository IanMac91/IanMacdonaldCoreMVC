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
        public string ArtistName { get; set; }
        public Genre Genre { get; set; }
        public virtual List<Album> Albums { get; set; }
    }
}

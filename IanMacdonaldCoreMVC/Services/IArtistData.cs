using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IanMacdonaldCoreMVC.Models;

namespace IanMacdonaldCoreMVC.Services
{
    public interface IArtistData
    {
        IEnumerable<Artist> GetArtists();
        Artist GetArtist(int Id);
        Artist AddArtist(Artist artist);
    }
}

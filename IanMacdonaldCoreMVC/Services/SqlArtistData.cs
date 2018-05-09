using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IanMacdonaldCoreMVC.Models;
using IanMacdonaldCoreMVC.Data;
using Microsoft.EntityFrameworkCore;

namespace IanMacdonaldCoreMVC.Services
{
    public class SqlArtistData : IArtistData
    {
        private IanMacdonaldDbContext _Context;

        public SqlArtistData(IanMacdonaldDbContext context)
        {
            _Context = context;
        }

        public Artist AddArtist(Artist artist)
        {
            _Context.Artists.Add(artist);
            _Context.SaveChanges();
            return artist;
        }

        public Artist GetArtist(int Id)
        {
            return _Context.Artists.FirstOrDefault(A => A.ArtistId == Id);
        }

        public IEnumerable<Artist> GetArtists()
        {
            return _Context.Artists.OrderBy(A => A.ArtistName);
        }
    }
}

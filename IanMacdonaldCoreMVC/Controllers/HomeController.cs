using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using IanMacdonaldCoreMVC.Models;
using IanMacdonaldCoreMVC.Services;

namespace IanMacdonaldCoreMVC.Controllers
{
    public class HomeController : Controller
    {
        private IArtistData _artistData;

        public HomeController(IArtistData artistData)
        {
            _artistData = artistData;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var model = _artistData.GetArtists();
            return View(model);
        }

        [HttpGet]
        public IActionResult Details(int Id)
        {
            var model = _artistData.GetArtist(Id);
            return View(model);
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(Artist model)
        {
            if (ModelState.IsValid)
            {
                var newArtist = new Artist();
                newArtist.ArtistName = model.ArtistName;
                newArtist.Genre = model.Genre;

                newArtist = _artistData.AddArtist(newArtist);

                return RedirectToAction(nameof(Details), new { Id = newArtist.ArtistId });
            }
            else
            {
                return View();
            }
            
        }
    }
}
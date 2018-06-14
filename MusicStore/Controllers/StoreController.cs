using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MusicStore.Models;

namespace MusicStore.Controllers
{
    public class StoreController : Controller
    {
        MusicStoreEntities storeDB = new MusicStoreEntities();

        // List of Genres
        public ActionResult Index()
        {
            var genres = storeDB.Genres.ToList();
            return View(genres);
        }

        // List of Albums for a particular Genre
        public ActionResult BrowseGenreAlbums(string genre)
        {
            var genreModel = storeDB.Genres.Include("Albums").Single(g => g.Name == genre);
            return View(genreModel);
        }

        // Details of an Album
        public ActionResult AlbumDetails(int id)
        {
            var album = storeDB.Albums.Find(id);
            return View(album);
        }
    }
}
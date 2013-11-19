using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FuckTheNorthIsland.PhotoProviders;
using System.Web.Mvc;

namespace FuckTheNorthIsland.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
			var factory = new PhotoProviderFactory();
			var photos = factory.GetAllPhotos();
			
            return View(photos);
        }

    }
}

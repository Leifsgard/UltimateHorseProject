using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProjectHorse.Models;

namespace ProjectHorse.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            var model = new HomeIndexViewModel()
            {
                Objects = new List<string>(){"Hej div 1","Div 2 här","div 3 här kanske?","Div 4 Kommer nu!"},
                TopSideNews = "Här ska en nyhet visas!"
            };
            
            

            return View(model);
        }
        [ChildActionOnly] 
        public ActionResult HomePageHorses()//Partialview to show random? four horses on front page
        {
            var model = new HomePageHorsesModel()
            {
                Horses = new List<string>()
                {
                    "Pietra Du Claud",
                    "Rikita de la Tour",
                    "Delta du Nord",
                    "Écho du Nord"
                }
            };
            return PartialView("_HomePageHorses",model);
        }

        [ChildActionOnly]
        public ActionResult HomePageCarousel()
        {
            return PartialView("_HomePageCarousel");
        }
    }
}
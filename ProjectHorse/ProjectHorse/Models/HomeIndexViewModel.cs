using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectHorse.Models
{
    public class HomeIndexViewModel
    {
        public List<string> Objects { get; set; } //Temp list of string, replace with news/Blogposts later
        public string TopSideNews { get; set; } //Temp string, replace with latest news object to go topside on homepage


        public HomeIndexViewModel()
        {
            Objects = new List<string>();
        }
    }
}
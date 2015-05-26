using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectHorse.Models
{
    public class HomePageHorsesModel
    {
        public List<string> Horses { get; set; } //Temp list of string, change into Horse objects later 

        public HomePageHorsesModel()
        {
            Horses = new List<string>();
        }
    }
}
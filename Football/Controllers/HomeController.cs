using Football.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Football.Controllers
{
    public class HomeController : Controller
    {
        public static List<Player> RB = new List<Player>
         {
                        new Player { PlayerId = 1, LastName = "Gurley", FirstName = "Todd", Rush = 279, RushYards = 1305, RushTd = 13, Targets = 87, Rec = 64, RecYards = 788, RecTd = 6, Fum = 5 },
                        new Player { PlayerId = 2, LastName = "Bell", FirstName = "Le'Veon", Rush = 321, RushYards = 1291, RushTd = 9, Targets = 107, Rec = 85, RecYards = 655, RecTd = 2, Fum = 3 }
        };

        public ActionResult Index()
        {
            var playerList = new PlayerListViewModel
            {
                //Convert each Person to a PersonViewModel
                Plax = Plax.Select(p => new PlayerViewModel
                {
                    PlayerId = p.PlayerId,
                    LastName = p.LastName,
                    FirstName = p.FirstName
                }).ToList()
            };

            playerList.TotalPlax = playerList.Plax.Count;

            return View(playerList);
        }

        public ActionResult BrowsePlayers()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
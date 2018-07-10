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
        public static List<Player> Team = new List<Player>
        {
           /*new Player { PlayerId = 1, Position = "QB", LastName = "Sample", FirstName = "Sample", Rush = 1, RushYards = 10, RushTd = 10, Targets = 10, Rec = 10, RecYards = 10, RecTd = 10, Fum = 10 },
           new Player { PlayerId = 1, Position = "QB", LastName = "Sample", FirstName = "Sample", Rush = 1, RushYards = 10, RushTd = 10, Targets = 10, Rec = 10, RecYards = 10, RecTd = 10, Fum = 10 },
           new Player { PlayerId = 1, Position = "QB", LastName = "Sample", FirstName = "Sample", Rush = 1, RushYards = 10, RushTd = 10, Targets = 10, Rec = 10, RecYards = 10, RecTd = 10, Fum = 10 },
           new Player { PlayerId = 1, Position = "QB", LastName = "Sample", FirstName = "Sample", Rush = 1, RushYards = 10, RushTd = 10, Targets = 10, Rec = 10, RecYards = 10, RecTd = 10, Fum = 10 },
           new Player { PlayerId = 1, Position = "QB", LastName = "Sample", FirstName = "Sample", Rush = 1, RushYards = 10, RushTd = 10, Targets = 10, Rec = 10, RecYards = 10, RecTd = 10, Fum = 10 },
           new Player { PlayerId = 1, Position = "QB", LastName = "Sample", FirstName = "Sample", Rush = 1, RushYards = 10, RushTd = 10, Targets = 10, Rec = 10, RecYards = 10, RecTd = 10, Fum = 10 },
           new Player { PlayerId = 1, Position = "QB", LastName = "Sample", FirstName = "Sample", Rush = 1, RushYards = 10, RushTd = 10, Targets = 10, Rec = 10, RecYards = 10, RecTd = 10, Fum = 10 },
           new Player { PlayerId = 1, Position = "QB", LastName = "Sample", FirstName = "Sample", Rush = 1, RushYards = 10, RushTd = 10, Targets = 10, Rec = 10, RecYards = 10, RecTd = 10, Fum = 10 },*/
        };

        public ActionResult Index(Player player)
        {
            if (player != null)
            {
                Team.Add(player);
            }
            var playerList = new PlayerListViewModel
            {
                //Convert each Person to a PersonViewModel
                Plax = Team.Select(p => new PlayerViewModel
                {
                    PlayerId = p.PlayerId,
                    Position = p.Position,
                    LastName = p.LastName,
                    FirstName = p.FirstName,
                    Rush = p.Rush,
                    RushYards = p.RushYards,
                    RushTd = p.RushTd,
                    Targets = p.Targets,
                    Rec = p.Rec,
                    RecYards = p.RecYards,
                    RecTd = p.RecTd,
                    Fum = p.Fum,
                    Attempts = p.Attempts,
                    PassTd = p.PassTd,
                    PassYards = p.PassYards
                }).ToList()
            };

            return View(playerList);
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        /*[HttpPost]
        public ActionResult AddPlayer(PlayerViewModel playerViewModel, List<Player> players)
        {
            var nextPlayerId = Team.Max(p => p.PlayerId) + 1;

            var player = new Player
            {
                PlayerId = nextPlayerId,
                Position = players.Position,
                LastName = playerViewModel.LastName,
                FirstName = playerViewModel.FirstName,
                Rush = playerViewModel.Rush,
                RushYards = playerViewModel.RushYards,
                RushTd = playerViewModel.RushTd,
                Targets = playerViewModel.Targets,
                Rec = playerViewModel.Rec,
                RecYards = playerViewModel.RecYards,
                RecTd = playerViewModel.RecTd,
                Fum = playerViewModel.Fum,
                Attempts = playerViewModel.Attempts,
                PassTd = playerViewModel.PassTd,
                PassYards = playerViewModel.PassYards
            };

            Team.Add(player);

            return RedirectToAction("Index");
        }*/
    }
}
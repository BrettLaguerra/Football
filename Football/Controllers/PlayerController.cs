using Football.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Football.Controllers
{
    public class PlayerController : Controller
    {
        public static List<Player> Team = new List<Player>()
        {
            new Player {},
            new Player {},
            new Player {},
            new Player {},
            new Player {},
            new Player {},
            new Player {}
        };

        public static List<Player> RB = new List<Player>()
            {
                        new Player { PlayerId = 1, Position = "RB", LastName = "Gurley", FirstName = "Todd", Rush = 279, RushYards = 1305, RushTd = 13, Targets = 87, Rec = 64, RecYards = 788, RecTd = 6, Fum = 5 },
                        new Player { PlayerId = 2, Position = "RB", LastName = "Bell", FirstName = "Le'Veon", Rush = 321, RushYards = 1291, RushTd = 9, Targets = 107, Rec = 85, RecYards = 655, RecTd = 2, Fum = 3 },
                        new Player { PlayerId = 3, Position = "RB", LastName = "Kamara", FirstName = "Alvin", Rush = 120, RushYards = 728, RushTd = 8, Targets = 100, Rec = 81, RecYards = 826, RecTd = 5, Fum = 1 },
                        new Player { PlayerId = 4, Position = "RB", LastName = "Hunt", FirstName = "Kareem", Rush = 272, RushYards = 1327, RushTd = 8, Targets = 63, Rec = 53, RecYards = 455, RecTd = 3, Fum = 1 },
                        new Player { PlayerId = 5, Position = "RB", LastName = "Gordon", FirstName = "Melvin", Rush = 284, RushYards = 1105, RushTd = 8, Targets = 83, Rec = 58, RecYards = 476, RecTd = 4, Fum = 0 },
                        new Player { PlayerId = 6, Position = "RB", LastName = "Ingram", FirstName = "Mark", Rush = 230, RushYards = 1124, RushTd = 12, Targets = 71, Rec = 58, RecYards = 416, RecTd = 0, Fum = 3 },
                        new Player { PlayerId = 7, Position = "RB", LastName = "McCoy", FirstName = "LeSean", Rush = 287, RushYards = 1138, RushTd = 6, Targets = 77, Rec = 59, RecYards = 448, RecTd = 2, Fum = 1 },
                        new Player { PlayerId = 8, Position = "RB", LastName = "Hyde", FirstName = "Carlos", Rush = 240, RushYards = 938, RushTd = 8, Targets = 87, Rec = 59, RecYards = 350, RecTd = 0, Fum = 1 },
                        new Player { PlayerId = 9, Position = "RB", LastName = "Fournette", FirstName = "Leonard", Rush = 268, RushYards = 1040, RushTd = 9, Targets = 48, Rec = 36, RecYards = 302, RecTd = 1, Fum = 0 },
                        new Player { PlayerId = 10, Position = "RB", LastName = "McCaffrey", FirstName = "Christian", Rush = 117, RushYards = 435, RushTd = 2, Targets = 113, Rec = 80, RecYards = 651, RecTd = 5, Fum = 1 },
                        new Player { PlayerId = 11, Position = "RB", LastName = "Johnson", FirstName = "Duke", Rush = 82, RushYards = 348, RushTd = 4, Targets = 93, Rec = 74, RecYards = 693, RecTd = 3, Fum = 2 },
                        new Player { PlayerId = 12, Position = "RB", LastName = "Elliot", FirstName = "Ezekeiel", Rush = 242, RushYards = 983, RushTd = 7, Targets = 38, Rec = 26, RecYards = 269, RecTd = 2, Fum = 1 },
                        new Player { PlayerId = 13, Position = "RB", LastName = "Freeman", FirstName = "Deonta", Rush = 196, RushYards = 865, RushTd = 7, Targets = 46, Rec = 36, RecYards = 317, RecTd = 1, Fum = 1 },
                        new Player { PlayerId = 14, Position = "RB", LastName = "Howard", FirstName = "Jordan", Rush = 276, RushYards = 1122, RushTd = 9, Targets = 32, Rec = 23, RecYards = 125, RecTd = 0, Fum = 1 },
                        new Player { PlayerId = 15, Position = "RB", LastName = "Lewis", FirstName = "Dion", Rush = 180, RushYards = 896, RushTd = 6, Targets = 36, Rec = 32, RecYards = 214, RecTd = 3, Fum = 0 },
                        new Player { PlayerId = 16, Position = "RB", LastName = "Miller", FirstName = "Lamar", Rush = 238, RushYards = 888, RushTd = 3, Targets = 45, Rec = 36, RecYards = 327, RecTd = 3, Fum = 0 },
                        new Player { PlayerId = 17, Position = "RB", LastName = "McKinnon", FirstName = "Jerick", Rush = 150, RushYards = 570, RushTd = 3, Targets = 68, Rec = 51, RecYards = 421, RecTd = 2, Fum = 2 },
                        new Player { PlayerId = 18, Position = "RB", LastName = "Anderson", FirstName = "CJ", Rush = 245, RushYards = 1007, RushTd = 3, Targets = 40, Rec = 28, RecYards = 224, RecTd = 1, Fum = 1 },
                        new Player { PlayerId = 19, Position = "RB", LastName = "Gore", FirstName = "Frank", Rush = 261, RushYards = 961, RushTd = 3, Targets = 38, Rec = 29, RecYards = 245, RecTd = 1, Fum = 0 },
                        new Player { PlayerId = 20, Position = "RB", LastName = "Murray", FirstName = "DeMarco", Rush = 184, RushYards = 659, RushTd = 6, Targets = 47, Rec = 39, RecYards = 266, RecTd = 1, Fum = 1 },
            };

        public static List<Player> QB = new List<Player>()
            {
                        new Player { PlayerId = 1, Position = "QB", LastName = "Wilson", FirstName = "Russell", Attempts = 553, PassYards = 3983, PassTd = 34, RushYards = 586, RushTd = 3, Pick = 11, Fum = 3 },
                        new Player { PlayerId = 2, Position = "QB", LastName = "Newton", FirstName = "Cam", Attempts = 492, PassYards = 3302, PassTd = 22, RushYards = 754, RushTd = 6, Pick = 16, Fum = 1 },
                        new Player { PlayerId = 3, Position = "QB", LastName = "Brady", FirstName = "Tom", Attempts = 581, PassYards = 4577, PassTd = 32, RushYards = 28, RushTd = 0, Pick = 8, Fum = 3 },
                        new Player { PlayerId = 4, Position = "QB", LastName = "Smith", FirstName = "Alex", Attempts = 505, PassYards = 4042, PassTd = 26, RushYards = 355, RushTd = 1, Pick = 5, Fum = 1 },
                        new Player { PlayerId = 5, Position = "QB", LastName = "Wentz", FirstName = "Carson", Attempts = 440, PassYards = 3296, PassTd = 33, RushYards = 299, RushTd = 0, Pick = 7, Fum = 3 },
                        new Player { PlayerId = 6, Position = "QB", LastName = "Cousins", FirstName = "Kirk", Attempts = 540, PassYards = 4093, PassTd = 13, RushYards = 179, RushTd = 4, Pick = 13, Fum = 5 },
                        new Player { PlayerId = 7, Position = "QB", LastName = "Stafford", FirstName = "Matthew", Attempts = 565, PassYards = 4446, PassTd = 29, RushYards = 98, RushTd = 0, Pick = 10, Fum = 7 },
                        new Player { PlayerId = 8, Position = "QB", LastName = "Rivers", FirstName = "Phillip", Attempts = 575, PassYards = 4515, PassTd = 28, RushYards = -2, RushTd = 0, Pick = 10, Fum = 1 },
                        new Player { PlayerId = 9, Position = "QB", LastName = "Brees", FirstName = "Drew", Attempts = 536, PassYards = 4334, PassTd = 23, RushYards = 12, RushTd = 2, Pick = 8, Fum = 0 },
                        new Player { PlayerId = 10, Position = "QB", LastName = "Prescott", FirstName = "Dak", Attempts = 490, PassYards = 3324, PassTd = 22, RushYards = 357, RushTd = 6, Pick = 13, Fum = 3 },
                        new Player { PlayerId = 11, Position = "QB", LastName = "Roethlisberger", FirstName = "Ben", Attempts = 561, PassYards = 4251, PassTd = 28, RushYards = 47, RushTd = 0, Pick = 14, Fum = 1 },
                        new Player { PlayerId = 12, Position = "QB", LastName = "Goff", FirstName = "Jared", Attempts = 477, PassYards = 3804, PassTd = 28, RushYards = 51, RushTd = 1, Pick = 7, Fum = 3 },
                        new Player { PlayerId = 13, Position = "QB", LastName = "Bortles", FirstName = "Blake", Attempts = 523, PassYards = 3687, PassTd = 21, RushYards = 322, RushTd = 2, Pick = 13, Fum = 3 },
                        new Player { PlayerId = 14, Position = "QB", LastName = "Keenum", FirstName = "Case", Attempts = 481, PassYards = 3547, PassTd = 22, RushYards = 160, RushTd = 1, Pick = 7, Fum = 1 },
                        new Player { PlayerId = 15, Position = "QB", LastName = "Ryan", FirstName = "Matt", Attempts = 529, PassYards = 4095, PassTd = 20, RushYards = 143, RushTd = 0, Pick = 12, Fum = 3 },
                        new Player { PlayerId = 16, Position = "QB", LastName = "Taylor", FirstName = "Tyrod", Attempts = 420, PassYards = 2799, PassTd = 14, RushYards = 427, RushTd = 4, Pick = 4, Fum = 2 },
                        new Player { PlayerId = 17, Position = "QB", LastName = "Dalton", FirstName = "Andy", Attempts = 496, PassYards = 3320, PassTd = 25, RushYards = 99, RushTd = 0, Pick = 12, Fum = 4 },
                        new Player { PlayerId = 18, Position = "QB", LastName = "Mariota", FirstName = "Marcus", Attempts = 453, PassYards = 3232, PassTd = 13, RushYards = 312, RushTd = 5, Pick = 15, Fum = 1 },
                        new Player { PlayerId = 19, Position = "QB", LastName = "Carr", FirstName = "Derek", Attempts = 515, PassYards = 3496, PassTd = 22, RushYards = 66, RushTd = 0, Pick = 13, Fum = 3 },
                        new Player { PlayerId = 20, Position = "QB", LastName = "Brissett", FirstName = "Jacoby", Attempts = 469, PassYards = 3098  , PassTd = 13, RushYards = 260, RushTd = 4, Pick = 7, Fum = 3 },
            };

        public static List<Player> WR = new List<Player>()
            {
                        new Player { PlayerId = 1, Position = "WR", LastName = "Brown", FirstName = "Antonio", Targets = 162, Rec = 101, RecYards = 1533, RecTd = 9, Fum = 0 },
                        new Player { PlayerId = 2, Position = "WR", LastName = "Hopkins", FirstName = "DeAndre", Targets = 175, Rec = 96, RecYards = 1378, RecTd = 13, Fum = 1 },
                        new Player { PlayerId = 3, Position = "WR", LastName = "Allen", FirstName = "Keenen", Targets = 159, Rec = 102, RecYards = 1393, RecTd = 6, Fum = 0 },
                        new Player { PlayerId = 4, Position = "WR", LastName = "Fitzgerald", FirstName = "Larry", Targets = 162, Rec = 109, RecYards = 1156, RecTd = 6, Fum = 1 },
                        new Player { PlayerId = 5, Position = "WR", LastName = "Landry", FirstName = "Jarvis", Targets = 160, Rec = 112, RecYards = 987, RecTd = 9, Fum = 2 },
                        new Player { PlayerId = 6, Position = "WR", LastName = "Thomas", FirstName = "Michael", Targets = 149, Rec = 104, RecYards = 1245, RecTd = 5, Fum = 0 },
                        new Player { PlayerId = 7, Position = "WR", LastName = "Jones", FirstName = "Julio", Targets = 149, Rec = 88, RecYards = 1444, RecTd = 3, Fum = 0 },
                        new Player { PlayerId = 8, Position = "WR", LastName = "Thielen", FirstName = "Adam", Targets = 143, Rec = 91, RecYards = 1276, RecTd = 4, Fum = 2 },
                        new Player { PlayerId = 9, Position = "WR", LastName = "Hill", FirstName = "Tyreek", Targets = 105, Rec = 75, RecYards = 1183, RecTd = 7, Fum = 0 },
                        new Player { PlayerId = 10, Position = "WR", LastName = "Green", FirstName = "AJ", Targets = 145, Rec = 75, RecYards = 1078, RecTd = 8, Fum = 2 },
                        new Player { PlayerId = 11, Position = "WR", LastName = "Baldwin", FirstName = "Doug", Targets = 108, Rec = 75, RecYards = 991, RecTd = 8, Fum = 0 },
                        new Player { PlayerId = 12, Position = "WR", LastName = "Jones", FirstName = "Marvin", Targets = 122, Rec = 61, RecYards = 1101, RecTd = 9, Fum = 0 },
                        new Player { PlayerId = 13, Position = "WR", LastName = "Tate", FirstName = "Golden", Targets = 117, Rec = 92, RecYards = 1003, RecTd = 5, Fum = 1 },
                        new Player { PlayerId = 14, Position = "WR", LastName = "Adams", FirstName = "DeVante", Targets = 118, Rec = 74, RecYards = 885, RecTd = 10, Fum = 0 },
                        new Player { PlayerId = 15, Position = "WR", LastName = "Cooks", FirstName = "Brandin", Targets = 114, Rec = 65, RecYards = 1082, RecTd = 7, Fum = 0 },
                        new Player { PlayerId = 16, Position = "WR", LastName = "Thomas", FirstName = "Demaryius", Targets = 141, Rec = 83, RecYards = 949, RecTd = 5, Fum = 1 },
                        new Player { PlayerId = 17, Position = "WR", LastName = "Evans", FirstName = "Mike", Targets = 135, Rec = 71, RecYards = 1001, RecTd = 5, Fum = 0 },
                        new Player { PlayerId = 18, Position = "WR", LastName = "Anderson", FirstName = "Robby", Targets = 114, Rec = 63, RecYards = 941, RecTd = 7, Fum = 0 },
                        new Player { PlayerId = 19, Position = "WR", LastName = "Diggs", FirstName = "Stefon", Targets = 95, Rec = 64, RecYards = 849, RecTd = 8, Fum = 0 },
                        new Player { PlayerId = 20, Position = "WR", LastName = "Jeffrey", FirstName = "Alshon", Targets = 80, Rec = 57, RecYards = 789, RecTd = 9, Fum = 0 },
            };

        public static List<Player> TE = new List<Player>()
            {
                        new Player { PlayerId = 1, Position = "TE", LastName = "Kelce", FirstName = "Travis", Targets = 123, Rec = 83, RecYards = 1038, RecTd = 8, Fum = 0 },
                        new Player { PlayerId = 2, Position = "TE", LastName = "Gronkowsi", FirstName = "Rob", Targets = 106, Rec = 69, RecYards = 1084, RecTd = 8, Fum = 0 },
                        new Player { PlayerId = 3, Position = "TE", LastName = "Ertz", FirstName = "Zach", Targets = 110, Rec = 74, RecYards = 824, RecTd = 8, Fum = 1 },
                        new Player { PlayerId = 4, Position = "TE", LastName = "Walker", FirstName = "Delanie", Targets = 111, Rec = 74, RecYards = 807, RecTd = 3, Fum = 2 },
                        new Player { PlayerId = 5, Position = "TE", LastName = "Engram", FirstName = "Evan", Targets = 115, Rec = 64, RecYards = 722, RecTd = 6, Fum = 0 },
                        new Player { PlayerId = 6, Position = "TE", LastName = "Graham", FirstName = "Jimmy", Targets = 97, Rec = 57, RecYards = 520, RecTd = 10, Fum = 0 },
                        new Player { PlayerId = 7, Position = "TE", LastName = "Doyle", FirstName = "Jack", Targets = 107, Rec = 80, RecYards = 690, RecTd = 4, Fum = 2 },
                        new Player { PlayerId = 8, Position = "TE", LastName = "Rudolph", FirstName = "Kyle", Targets = 81, Rec = 57, RecYards = 532, RecTd = 8, Fum = 0 },
                        new Player { PlayerId = 9, Position = "TE", LastName = "Witten", FirstName = "Jason", Targets = 87, Rec = 63, RecYards = 560, RecTd = 5, Fum = 1 },
                        new Player { PlayerId = 10, Position = "TE", LastName = "Brate", FirstName = "Cameron", Targets = 77, Rec = 48, RecYards = 591, RecTd = 6, Fum = 0 },
                        new Player { PlayerId = 11, Position = "TE", LastName = "Watson", FirstName = "Benjamin", Targets = 79, Rec = 61, RecYards = 522, RecTd = 4, Fum = 0 },
                        new Player { PlayerId = 12, Position = "TE", LastName = "Cook", FirstName = "Jared", Targets = 86, Rec = 54, RecYards = 688, RecTd = 2, Fum = 1 },
                        new Player { PlayerId = 13, Position = "TE", LastName = "Ebron", FirstName = "Eric", Targets = 86, Rec = 53, RecYards = 574, RecTd = 4, Fum = 1 },
                        new Player { PlayerId = 14, Position = "TE", LastName = "Henry", FirstName = "Hunter", Targets = 63, Rec = 45, RecYards = 579, RecTd = 4, Fum = 0 },
                        new Player { PlayerId = 15, Position = "TE", LastName = "Kroft", FirstName = "Tyler", Targets = 62, Rec = 42, RecYards = 404, RecTd = 7, Fum = 0 },
                        new Player { PlayerId = 16, Position = "TE", LastName = "Davis", FirstName = "Vernon", Targets = 69, Rec = 43, RecYards = 648, RecTd = 3, Fum = 2 },
                        new Player { PlayerId = 17, Position = "TE", LastName = "Hooper", FirstName = "Austin", Targets = 65, Rec = 49, RecYards = 526, RecTd = 3, Fum = 0 },
                        new Player { PlayerId = 18, Position = "TE", LastName = "Clay", FirstName = "Charles", Targets = 74, Rec = 49, RecYards = 558, RecTd = 2, Fum = 0 },
                        new Player { PlayerId = 19, Position = "TE", LastName = "Kittle", FirstName = "George", Targets = 63, Rec = 43, RecYards = 515, RecTd = 2, Fum = 0 },
                        new Player { PlayerId = 20, Position = "TE", LastName = "Sefarian-Jenkins", FirstName = "Austin", Targets = 74, Rec = 50, RecYards = 357, RecTd = 3, Fum = 1 }
            };

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult QBList()
        {
            var playerList = new PlayerListViewModel
            {
                //Convert each Person to a PersonViewModel
                Plax = QB.Select(p => new PlayerViewModel
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

        public ActionResult TEList()
        {
            var playerList = new PlayerListViewModel
            {
                //Convert each Person to a PersonViewModel
                Plax = TE.Select(p => new PlayerViewModel
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

        public ActionResult RBList()
        {
            var playerList = new PlayerListViewModel
            {
                //Convert each Person to a PersonViewModel
                Plax = RB.Select(p => new PlayerViewModel
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

        public ActionResult WRList()
        {
            var playerList = new PlayerListViewModel
            {
                //Convert each Person to a PersonViewModel
                Plax = WR.Select(p => new PlayerViewModel
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


        /************* CRUD OPERATIONS **************/

        [HttpPost]
        public ActionResult QBEdit()
        {
            string LastName = Request.Form["LastName"];
            string FirstName = Request.Form["FirstName"];
            var player = RB.SingleOrDefault(p => (p.LastName.Equals(LastName, StringComparison.OrdinalIgnoreCase) && (p.FirstName.Equals(FirstName, StringComparison.OrdinalIgnoreCase))));
            if (player != null)
            {
                return RedirectToAction("Index", "Home", player);
            }
            //set up an error catch for position
            //use viewbag
            return new HttpNotFoundResult();
        }

        [HttpPost]
        public ActionResult EditQB(PlayerViewModel playerViewModel)
        {
            var person = QB.SingleOrDefault(p => p.PlayerId == playerViewModel.PlayerId);

            if (person != null)
            {
                person.LastName = playerViewModel.LastName;
                person.FirstName = playerViewModel.FirstName;

                return RedirectToAction("Index", "Home");
            }

            return new HttpNotFoundResult();
        }

        /*[HttpPost]
        public ActionResult AddPlayer(PlayerViewModel personViewModel)
        {
            var nextPlayerId = Team.Max(p => p.PlayerId) + 1;

            var player = new Player
            {
                PlayerId = nextPlayerId,
                LastName = personViewModel.LastName,
                FirstName = personViewModel.FirstName
            };

            Team.Add(player);

            return RedirectToAction("Index", "Home");
        }*/

        public ActionResult AddQB()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
    }
}
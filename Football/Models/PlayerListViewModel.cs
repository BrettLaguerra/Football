using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Football.Models
{
    public class PlayerListViewModel
    {
        public List<PlayerViewModel> Plax { get; set; }
        public int TotalPlax { get; set; }
    }
}
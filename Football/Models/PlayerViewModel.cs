using System.ComponentModel;

namespace Football.Models
{
    public class PlayerViewModel
    {
        public int? PlayerId { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }

        public int? Rush { get; set; }
        public int? RushYards { get; set; }
        public int? RushTd { get; set; }

        public int? Targets { get; set; }
        public int? Rec { get; set; }
        public int? RecYards { get; set; }
        public int? RecTd { get; set; }

        public int? Attempts { get; set; }
        public int? PassYards { get; set; }
        public int? PassTd { get; set; }
        public int? Pick { get; set; }

        public int? Fum { get; set; }
    }
}
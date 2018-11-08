using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SpelarPortalenMVC1.Models
{
    public class PlayerLeagueVM
    {
        public List<PlayerLeague> ListPlayers { get; set; }
    }
    public class PlayerLeague
    {
        public string PTeamName { get; set; }
        public string PFirstName{ get; set; }
        public string PSurname { get; set; }

        public int PGoals { get; set; }
        public int PAssists { get; set; }
    }
}
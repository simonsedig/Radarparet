using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SpelarPortalenMVC1.Models
{
    public class MatchDayModel
    {
        public List<Player> squadPlayers { get; set; }

        public Fixture FixtureHome { get; set; }
        public Fixture FixtureAway { get; set; }
        
        public List<Fixture> TeamGames { get; set; }      
        
        public List<AllFixtures> FixtureList { get; set; }
    }
    public class AllFixtures
    {

        public string JHomeTeamName { get; set; }
        public string JAwayTeamName { get; set; }

        public DateTime JDate { get; set; }
        public string JResult { get; set; }
        public string JReferee { get; set; }
        public string JArena { get; set; }
    }
}
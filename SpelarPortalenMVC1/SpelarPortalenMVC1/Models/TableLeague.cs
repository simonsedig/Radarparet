using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SpelarPortalenMVC1.Models
{
    public class TableLeagueVM
    {
       public List<TeamInTable> TeamLists { get; set; }
    }
    public class TeamInTable
    {
        public string TName { get; set; }
        
        public int TPlayerGames { get; set; }
        public int TWins { get; set; }
        public int TDraw { get; set; }
        public int TLost { get; set; }
        public int TPoints { get; set; }
    }
}
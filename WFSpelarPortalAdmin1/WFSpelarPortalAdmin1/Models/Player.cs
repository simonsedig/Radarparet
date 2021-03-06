//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WFSpelarPortalAdmin1.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Player
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Player()
        {
            this.CurrentSquads = new HashSet<CurrentSquad>();
        }
    
        public int PlayerId { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public System.DateTime BirthDate { get; set; }
        public string Position { get; set; }
        public int ShirtNumber { get; set; }
        public int PlayedGames { get; set; }
        public int Goals { get; set; }
        public int Assists { get; set; }
        public int YellowCards { get; set; }
        public int RedCards { get; set; }
        public bool Injured { get; set; }
        public int UserId { get; set; }
        public int TeamId { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CurrentSquad> CurrentSquads { get; set; }
        public virtual Team Team { get; set; }
        public virtual User User { get; set; }
    }
}

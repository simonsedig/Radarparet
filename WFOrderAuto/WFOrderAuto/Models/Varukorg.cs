//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WFOrderAuto.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Varukorg
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Varukorg()
        {
            this.ProduktTillagd = new HashSet<ProduktTillagd>();
        }
    
        public int VarukorgId { get; set; }
        public System.DateTime DatumSkapad { get; set; }
        public string DatumAvslutad { get; set; }
        public bool Betalad { get; set; }
        public bool Levererad { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProduktTillagd> ProduktTillagd { get; set; }
    }
}

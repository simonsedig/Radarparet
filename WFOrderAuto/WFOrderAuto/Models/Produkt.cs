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
    
    public partial class Produkt
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Produkt()
        {
            this.ProduktTillagd = new HashSet<ProduktTillagd>();
        }
    
        public int ProduktId { get; set; }
        public string Namn { get; set; }
        public decimal Pris { get; set; }
        public string Kategori { get; set; }
        public string Bildadress { get; set; }
        public string Vikt { get; set; }
        public string Lagerplats { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProduktTillagd> ProduktTillagd { get; set; }
    }
}

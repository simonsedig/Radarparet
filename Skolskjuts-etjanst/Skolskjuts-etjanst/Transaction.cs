//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Skolskjuts_etjanst
{
    using System;
    using System.Collections.Generic;
    
    public partial class Transaction
    {
        public int TransaktionsId { get; set; }
        public System.DateTime DepartureTime { get; set; }
        public string Driver { get; set; }
        public string PickUpPlace { get; set; }
        public string Destination { get; set; }
        public string Customer { get; set; }
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Voat.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Defaultsetsetup
    {
        public int Setup_id { get; set; }
        public int Set_id { get; set; }
        public string Subverse { get; set; }
    
        public virtual Defaultset Defaultset { get; set; }
        public virtual Subverse Subvers { get; set; }
    }
}
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace KnitHorizon.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class PERMISSION
    {
        public int ENO { get; set; }
        public int Per_No { get; set; }
        public string Comp_Code { get; set; }
        public string SHIFT { get; set; }
        public Nullable<System.DateTime> ADATE { get; set; }
        public string REASON { get; set; }
        public Nullable<System.DateTime> TIME_OUT { get; set; }
        public Nullable<System.DateTime> TIME_IN { get; set; }
        public Nullable<System.DateTime> EXPECTED_TIME { get; set; }
        public string AUTHORITY { get; set; }
    }
}

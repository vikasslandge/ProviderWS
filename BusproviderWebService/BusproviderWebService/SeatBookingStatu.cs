//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BusproviderWebService
{
    using System;
    using System.Collections.Generic;
    
    public partial class SeatBookingStatu
    {
        public int BusId { get; set; }
        public int SeatNo { get; set; }
        public string Status { get; set; }
        public string SeatType { get; set; }
    
        public virtual BusDetail BusDetail { get; set; }
    }
}

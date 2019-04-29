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
    
    public partial class BusDetail
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BusDetail()
        {
            this.FeedbackDetails = new HashSet<FeedbackDetail>();
            this.RouteDetails = new HashSet<RouteDetail>();
            this.SeatBookingStatus = new HashSet<SeatBookingStatu>();
        }
    
        public int BusId { get; set; }
        public string BusName { get; set; }
        public int Capacity { get; set; }
        public string Type { get; set; }
        public string BusNo { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FeedbackDetail> FeedbackDetails { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RouteDetail> RouteDetails { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SeatBookingStatu> SeatBookingStatus { get; set; }
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AniWebApp
{
    using System;
    using System.Collections.Generic;
    
    public partial class TrafficIncident
    {
        public long TI_ID { get; set; }
        public string TI_Congestion { get; set; }
        public string TI_Description { get; set; }
        public string TI_Detour { get; set; }
        public string TI_Lane { get; set; }
        public int TI_Severity { get; set; }
        public int TI_Type { get; set; }
        public bool TI_RoadClosed { get; set; }
        public bool TI_Verified { get; set; }
        public int TI_LocationID { get; set; }
        public Nullable<int> TI_EndLocationID { get; set; }
        public System.DateTime TI_CreatedTimeUTC { get; set; }
        public System.DateTime TI_ModifiedTimeUTC { get; set; }
        public Nullable<System.DateTime> TI_StartTimeUTC { get; set; }
        public Nullable<System.DateTime> TI_EndTimeUTC { get; set; }
        public System.DateTime TI_LastEncounteredTimeUTC { get; set; }
        public int TI_CreatedUserNodeID { get; set; }
    
        public virtual TrafficIncidentSeverity TrafficIncidentSeverity { get; set; }
        public virtual TrafficIncidentType TrafficIncidentType { get; set; }
        public virtual UserNode UserNode { get; set; }
    }
}

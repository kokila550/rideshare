//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace rideshare_service
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbl_booking
    {
        public int bk_id { get; set; }
        public Nullable<System.DateTime> bk_time { get; set; }
        public string bk_status { get; set; }
        public string bk_cusid { get; set; }
        public string bk_driverid { get; set; }
        public string bk_startloc { get; set; }
        public string bk_endloc { get; set; }
        public byte[] active { get; set; }
    }
}

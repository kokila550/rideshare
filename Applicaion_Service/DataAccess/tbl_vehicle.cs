//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataAccess
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbl_vehicle
    {
        public tbl_vehicle()
        {
            this.tbl_booking = new HashSet<tbl_booking>();
        }
    
        public int veh_id { get; set; }
        public string veh_regno { get; set; }
        public string veh_type { get; set; }
        public string veh_description { get; set; }
        public string veh_location { get; set; }
        public Nullable<int> veh_driverid { get; set; }
        public string veh_custrequest { get; set; }
        public string active { get; set; }
    
        public virtual ICollection<tbl_booking> tbl_booking { get; set; }
        public virtual tbl_driver tbl_driver { get; set; }
    }
}
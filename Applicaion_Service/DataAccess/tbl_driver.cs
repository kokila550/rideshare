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
    
    public partial class tbl_driver
    {
        public tbl_driver()
        {
            this.tbl_booking = new HashSet<tbl_booking>();
            this.tbl_vehicle = new HashSet<tbl_vehicle>();
        }
    
        public int dri_id { get; set; }
        public string dri_fname { get; set; }
        public string dri_lname { get; set; }
        public string dri_address { get; set; }
        public string dri_licence { get; set; }
        public string dri_nic { get; set; }
        public string dri_password { get; set; }
        public string active { get; set; }
        public string dri_phoneno { get; set; }
    
        public virtual ICollection<tbl_booking> tbl_booking { get; set; }
        public virtual ICollection<tbl_vehicle> tbl_vehicle { get; set; }
    }
}
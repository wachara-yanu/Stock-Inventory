//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ITST.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    
    public partial class Status
    {
        public Status()
        {
            this.Devices = new HashSet<Device>();
        }
    
        public int StatusID { get; set; }

        [Required(ErrorMessage = "StatusName Required")]
        public string Status1 { get; set; }
        public string Description { get; set; }
        public System.DateTime DateCreate { get; set; }
        public System.DateTime DateUpdate { get; set; }
        public string CreateBy { get; set; }
        public string UpdateBy { get; set; }
    
        public virtual ICollection<Device> Devices { get; set; }
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MinnerDataAccess
{
    using System;
    using System.Collections.Generic;
    
    public partial class MinerType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MinerType()
        {
            this.MiningServers = new HashSet<MiningServer>();
        }
    
        public System.Guid MinerID { get; set; }
        public Nullable<int> MinerTypeID { get; set; }
        public string MinerName { get; set; }
        public string MinerDescription { get; set; }
        public Nullable<int> MinerStatus { get; set; }
        public Nullable<System.DateTime> MinerCreateDate { get; set; }
        public Nullable<System.DateTime> MinerLastUpdate { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MiningServer> MiningServers { get; set; }
    }
}

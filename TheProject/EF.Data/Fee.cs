//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EF.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class Fee
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Fee()
        {
            this.StorageSelections = new HashSet<StorageSelection>();
        }
    
        public int FeeId { get; set; }
        public int StorageTypeId { get; set; }
        public int TimePassId { get; set; }
        public int Cost { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StorageSelection> StorageSelections { get; set; }
        public virtual StorageType StorageType { get; set; }
        public virtual TimePass TimePass { get; set; }
    }
}

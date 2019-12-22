//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CPC.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class CPCEmployee
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CPCEmployee()
        {
            this.CITVehicleCrews = new HashSet<CITVehicleCrew>();
            this.CPCVaultConsolidatedBundlesDetails = new HashSet<CPCVaultConsolidatedBundlesDetail>();
        }
    
        public System.Guid Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public Nullable<System.Guid> DepartmentId { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public System.Guid CreatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedOn { get; set; }
        public Nullable<System.Guid> UpdatedBy { get; set; }
        public Nullable<byte> Status { get; set; }
        public string CNIC { get; set; }
        public Nullable<bool> IsAssigned { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CITVehicleCrew> CITVehicleCrews { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CPCVaultConsolidatedBundlesDetail> CPCVaultConsolidatedBundlesDetails { get; set; }
    }
}
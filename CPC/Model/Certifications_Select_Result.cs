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
    
    public partial class Certifications_Select_Result
    {
        public System.Guid Id { get; set; }
        public System.Guid CertificateId { get; set; }
        public System.Guid UserId { get; set; }
        public string State { get; set; }
        public string Number { get; set; }
        public Nullable<System.DateTime> ExpiryDate { get; set; }
        public string Attachments { get; set; }
        public Nullable<byte> Status { get; set; }
        public string Remarks { get; set; }
        public string Title { get; set; }
    }
}
//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MVCApp.DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class Subscriber1_Timeouts
    {
        public System.Guid Id { get; set; }
        public string CorrelationId { get; set; }
        public string ReplyToAddress { get; set; }
        public bool Recoverable { get; set; }
        public Nullable<System.DateTime> Expires { get; set; }
        public string Headers { get; set; }
        public byte[] Body { get; set; }
        public long RowVersion { get; set; }
    }
}

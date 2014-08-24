using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCApp.Models
{
    public class AuditExt2
    {
        public virtual System.Guid Id { get; set; }
        public virtual string CorrelationId { get; set; }
        public virtual string ReplyToAddress { get; set; }
        public virtual bool Recoverable { get; set; }
        public virtual Nullable<System.DateTime> Expires { get; set; }
        public virtual string Headers { get; set; }
        public virtual byte[] Body { get; set; }
        public virtual long RowVersion { get; set; }
    }
}
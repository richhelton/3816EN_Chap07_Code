using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FluentNHibernate.Mapping;

namespace MVCApp.Mapping
{

    public class AuditExt2Map : ClassMap<MVCApp.Models.AuditExt2>
    {
        public AuditExt2Map()
        {
            Table("audit");
            Id(x => x.Id);
            Map(x => x.ReplyToAddress);
            Map(x => x.Recoverable);
            Map(x => x.Expires);
            Map(x => x.Headers);
            Map(x => x.Body);
            Map(x => x.RowVersion);
        }
    }    
}
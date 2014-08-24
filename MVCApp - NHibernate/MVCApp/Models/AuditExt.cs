using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCApp.Models
{
    public class AuditExt
    {
        public MVCApp.DAL.audit audit { get; set; }
        public string reader { get; set; }

    }
}
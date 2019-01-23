using System;
using System.Collections.Generic;
using System.Text;

namespace CoreAdmin.Commons
{
    public class AuditInfo
    {
        public DateTime Created { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime Modified { get; set; }
        public int? ModifiedBy { get; set; }
    }
}

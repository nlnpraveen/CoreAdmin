using System;
using System.Collections.Generic;
using System.Text;

namespace CoreAdmin.Commons
{
    public interface IAuditable
    {
        int Id { get; set; }
        AuditInfo AuditInfo { get; set; }
    }

    public class EntityBase : IAuditable
    {
        public EntityBase()
        {
            AuditInfo = new AuditInfo();
        }

        public virtual int Id { get; set; }

        public AuditInfo AuditInfo { get; set; }
    }
}

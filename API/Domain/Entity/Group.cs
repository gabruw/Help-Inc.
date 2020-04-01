using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entity
{
    public class Group : Default
    {
        public long Id { get; set; }
        public long IdProvider { get; set; }
        public virtual ICollection<Provider> GroupProvider { get; set; }
        public long IdOfficer { get; set; }
        public virtual Officer GroupOfficer { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Picture { get; set; }

    }
}

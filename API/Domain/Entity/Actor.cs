using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entity
{
    public class Actor : Default
    {
        public long Id { get; set; }
        public long IdLogin { get; set; }
        public virtual LoginUser ActorLoginUser { get; set; }
        public long IdAddress { get; set; }
        public virtual Address ActorAddress { get; set; }
        public string Name { get; set; }
        public int Phone { get; set; }
        public string Picture { get; set; }
    }
}

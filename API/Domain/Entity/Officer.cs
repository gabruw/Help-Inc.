using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entity
{
    public class Officer : Default
    {
        public long Id { get; set; }
        public long IdGroup { get; set; }
        public virtual Group GroupOfficer { get; set; }    
        public long IdProvider { get; set; }
        public virtual Provider ProviderOfficer { get; set; }
    }
}

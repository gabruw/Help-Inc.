using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entity
{
    public class Provider : Default
    {
        public IList<SkillLevel> Skills { get; set; }
        public Group Group { get; set; }
    }
}

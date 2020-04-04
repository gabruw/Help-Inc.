using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entity
{
    public class SkillLevel
    {
        public long Id { get; set; }
        public long IdSkill { get; set; }
        public virtual Skill SkillLevelSkill { get; set; }
        public string Level { get; set; }
    }
}

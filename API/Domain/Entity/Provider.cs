using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entity
{
    public class Provider : User
    {
        public long IdGroup { get; set; }

        [ForeignKey("IdGroup")]
        public virtual Group Group { get; set; }
        public virtual ICollection<SkillLevel> Skills { get; set; }

        public virtual Group ProviderGroup { get; set; }

        public override void Validate()
        {
            throw new NotImplementedException();
        }
    }
}
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entity
{
    public class SkillLevel : Default
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }
        public long IdSkill { get; set; }

        [ForeignKey("IdSkill")]
        public virtual Skill SkillLevelSkill { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [MinLength(8, ErrorMessage = "O campo precisa ter no mínimo 8 caracteres")]
        [MaxLength(11, ErrorMessage = "O campo precisa ter no máximo 11 caracteres")]
        public int Level { get; set; }

        public virtual Provider ProviderSkill { get; set; }

        public override void Validate()
        {
            ClearValidationMessage();

            if (Level.ToString().Length < 1)
            {
                AddError("O campo nível não foi informado.");
            }

            if (Level.ToString().Length > 0 && Level.ToString().Length < 240)
            {
                AddError("O campo nível não possui o número de caracteres esperados");
            }
        }
    }
}
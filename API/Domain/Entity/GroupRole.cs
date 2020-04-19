using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entity
{
    public class GroupRole : Default
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; } 
        public long IdProvider { get; set; }

        [ForeignKey("IdProvider")]
        public virtual Provider ProviderOfficer { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [MinLength(1, ErrorMessage = "O campo precisa ter no mínimo 1 caracteres")]
        [MaxLength(8, ErrorMessage = "O campo precisa ter no máximo 8 caracteres")]
        public int Role { get; set; }

        public virtual Group GroupRoleGroup { get; set; }

        public override void Validate()
        {
            throw new NotImplementedException();
        }
    }
}
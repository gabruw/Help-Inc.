using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entity
{
    public class Actor : Default
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }
        public long IdLogin { get; set; }

        [ForeignKey("IdLogin")]
        public virtual Login ActorLoginUser { get; set; }
        public long IdAddress { get; set; }

        [ForeignKey("IdAddress")]
        public virtual Address ActorAddress { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(240, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 3)]
        public string Name { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [MinLength(8, ErrorMessage = "O campo precisa ter no mínimo 8 caracteres")]
        [MaxLength(11, ErrorMessage = "O campo precisa ter no máximo 11 caracteres")]
        [RegularExpression(@"^(\(?\d{2}\)?\s)?(\d{4,5}\-\d{4})$", ErrorMessage = "O telefone apresenta um formato inválido")]
        public int Phone { get; set; }

        [MinLength(1)]
        [MaxLength(160)]
        [StringLength(160, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 1)]
        public string Picture { get; set; }

        public override void Validate()
        {
            throw new NotImplementedException();
        }
    }
}
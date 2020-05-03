using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entity
{
    public class Skill : Default
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(300, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 3)]
        public string Description { get; set; }

        [StringLength(160, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 1)]
        public string Picture { get; set; }

        public override void Validate()
        {
            ClearValidationMessage();

            if (Description.Length < 1)
            {
                AddError("O campo descrição não foi informado.");
            }

            if (Description.Length > 0 && Description.Length < 300)
            {
                AddError("O campo descrição não foi informado.");
            }

            if (Picture.Length > 160)
            {
                AddError("O campo Imagem possui mais caracteres do que o esperado.");
            }
        }
    }
}
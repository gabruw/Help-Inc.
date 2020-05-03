using System.ComponentModel.DataAnnotations;

namespace Domain.Entity
{
    public class User : Actor
    {
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [MinLength(8, ErrorMessage = "O campo precisa ter no mínimo 8 caracteres")]
        [MaxLength(11, ErrorMessage = "O campo precisa ter no máximo 11 caracteres")]
        [RegularExpression(@"^(\(?\d{2}\)?\s)?(\d{4,5}\-\d{4})$", ErrorMessage = "O Celular apresenta um formato inválido")]
        public long CellPhone { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [MinLength(8, ErrorMessage = "O campo precisa ter no mínimo 8 caracteres")]
        [MaxLength(11, ErrorMessage = "O campo precisa ter no máximo 11 caracteres")]
        public long Rg { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [MinLength(11, ErrorMessage = "O campo precisa ter 11 caracteres")]
        [MaxLength(11, ErrorMessage = "O campo precisa ter 11 caracteres")]
        public long Cpf { get; set; }

        public override void Validate()
        {
            ClearValidationMessage();

            if (CellPhone.ToString().Length < 1)
            {
                AddError("O campo celular não foi informado.");
            }

            if (CellPhone.ToString().Length > 0 && CellPhone.ToString().Length < 11)
            {
                AddError("O campo celular não possui o número de caracteres esperados.");
            }

            if (Rg.ToString().Length < 1)
            {
                AddError("O campo RG não foi informado.");
            }

            if (Rg.ToString().Length > 0 && Rg.ToString().Length < 11)
            {
                AddError("O campo RG não possuí o número de caracteres esperados.");
            }

            if (Cpf.ToString().Length < 1)
            {
                AddError("O campo CPF não foi informado.");
            }

            if (Cpf.ToString().Length > 0 && Cpf.ToString().Length < 11)
            {
                AddError("O campo CPF não possui o número de caracteres esperados.");
            }
        }

    }
}
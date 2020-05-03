using System.ComponentModel.DataAnnotations;

namespace Domain.Entity
{
    public class Company : Actor
    {
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(80, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 3)]
        public string TradingName { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [MinLength(14, ErrorMessage = "O campo precisa ter 14 caracteres")]
        [MaxLength(14, ErrorMessage = "O campo precisa ter 14 caracteres")]
        public long Cnpj { get; set; }

        public override void Validate()
        {
            ClearValidationMessage();

            if (TradingName.Length < 1)
            {
                AddError("O campo nome fantasia não foi informado.");
            }

            if (TradingName.Length > 0 && TradingName.Length < 80)
            {
                AddError("O campo nome fantasia não possui o número de caracteres esperados.");
            }

            if (Cnpj.ToString().Length < 1)
            {
                AddError("O campo CNPJ não foi informado.");
            }

            if (Cnpj.ToString().Length > 0 && Cnpj.ToString().Length < 14)
            {
                AddError("O campo CNPJ não possui o número de caracteres esperados.");
            }
        }
    }
}

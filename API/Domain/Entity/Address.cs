using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Domain.Entity
{
    public class Address : Default
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }
        public long IdGeolocalization { get; set; }

        [ForeignKey("IdGeolocalization")]
        public virtual Geolocalization GeolocalizationAddress { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(80, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 3)]
        public string Road { get; set; }

        [StringLength(80, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 3)]
        public string Neighborhood { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [MinLength(1, ErrorMessage = "O campo precisa ter no mínimo 1 caractere")]
        [MaxLength(8, ErrorMessage = "O campo precisa ter no máximo 8 caracteres")]
        public int Number { get; set; }

        [MinLength(3, ErrorMessage = "O campo precisa ter no mínimo 3 caracteres")]
        [MaxLength(40, ErrorMessage = "O campo precisa ter no máximo 40 caracteres")]
        public int Complement { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(60, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 3)]
        public string City { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(100, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 3)]
        public string Country { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [MinLength(8, ErrorMessage = "O campo precisa ter 8 caracteres")]
        [MaxLength(8, ErrorMessage = "O campo precisa ter 8 caracteres")]
        public int Cep { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(80, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 3)]
        public string Reference { get; set; }

        public override void Validate()
        {
            ClearValidationMessage();

            if (Road.Length < 1)
            {
                AddError("O campo rua não foi informado.");
            }

            if (Road.Length > 0 && Road.Length < 80)
            {
                AddError("O campo rua não possui o número de caracteres esperados.");
            }

            if (Neighborhood.Length > 0 && Neighborhood.Length < 80)
            {
                AddError("O campo vizinhança não possui o número de caracteres esperados.");
            }

            if (Number.ToString().Length < 1)
            {
                AddError("O campo número não foi informado.");
            }

            if (Number.ToString().Length > 0 && Number.ToString().Length < 11)
            {
                AddError("O campo número não possui o número de caracteres esperados.");
            }

            if (Complement.ToString().Length > 0 && Complement.ToString().Length < 40)
            {
                AddError("O campo complemento não possui o número de caracteres esperados.");
            }

            if (City.Length < 1)
            {
                AddError("O campo cidade não foi informado.");
            }
            
            if (City.Length > 0 && City.Length < 60)
            {
                AddError("O campo cidade não possui o número de caracteres esperados.");
            }

            if (Country.Length < 1)
            {
                AddError("O campo país não foi informado.");
            }

            if (Country.Length > 0 && Country.Length < 60)
            {
                AddError("O campo país não possui o número de caracteres esperados.");
            }

            if (Cep.ToString().Length < 1)
            {
                AddError("O campo CEP não foi informado.");
            }

            if (Cep.ToString().Length > 0 && Cep.ToString().Length < 8)
            {
                AddError("O campo CEP não possui o número de caracteres esperados.");
            }

            if (Reference.Length < 1)
            {
                AddError("O campo referência não foi informado.");
            }

            if (Reference.Length < 0 && Reference.Length > 80)
            {
                AddError("O campo referência não possui o número de caracteres esperados.");
            }
        }
    }
}
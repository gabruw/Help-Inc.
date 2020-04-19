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

        [MinLength(8, ErrorMessage = "O campo precisa ter no mínimo 8 caracteres")]
        [MaxLength(11, ErrorMessage = "O campo precisa ter no máximo 11 caracteres")]
        public int Complement { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(60, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 3)]
        public string City { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(100, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 3)]
        public string Country { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [MinLength(8, ErrorMessage = "O campo precisa ter 8 caracteres")]
        [MaxLength(11, ErrorMessage = "O campo precisa ter 8 caracteres")]
        public int Cep { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(80, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 3)]
        public string Reference { get; set; }

        public override void Validate()
        {
            throw new System.NotImplementedException();
        }
    }
}
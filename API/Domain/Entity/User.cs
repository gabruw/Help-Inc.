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
    }
}
﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entity
{
    public class Group : Default
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }
        public long IdProvider { get; set; }

        [ForeignKey("IdProvider")]
        public virtual ICollection<Provider> GroupProvider { get; set; }
        public long IdGroupRole { get; set; }

        [ForeignKey("IdGroupRole")]
        public virtual ICollection<GroupRole> GroupGroupRole { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(40, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 3)]
        public string Name { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(200, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 3)]
        public string Description { get; set; }

        [StringLength(160, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 1)]
        public string Picture { get; set; }

        public override void Validate()
        {
            ClearValidationMessage();

            if (Name.Length < 1)
            {
                AddError("O campo nome não foi informado.");
            }

            if (Name.Length > 0 && Name.Length < 240)
            {
                AddError("O campo nome não foi informado.");
            }

            if (Description.Length < 1)
            {
                AddError("O campo descrição não foi informado.");
            }

            if (Description.Length > 0 && Description.Length < 240)
            {
                AddError("O campo descrição não possui o número de caracteres esperados");
            }

            if (Picture.Length > 160)
            {
                AddError("O campo Imagem possui mais caracteres do que o esperado.");
            }
        }
    }
}
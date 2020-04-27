using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Treinamento.Pitang.ONS.Entities;

namespace Pitang.Treinamento.ONS.Entities
{
    public class Contact : BaseEntity
    {
        

        [Required(ErrorMessage = "Este campo é obrigatório")]
        [MaxLength(20, ErrorMessage = "Limite máximo atingido")]
        [MinLength(3, ErrorMessage = "Limite mínimo não atingido")]
        public String Name { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório")]
        [MaxLength(11, ErrorMessage = "Limite máximo atingido")]
        [MinLength(9, ErrorMessage = "Limite mínimo não atingido")]
        public String Number { get; set; }


    }
}

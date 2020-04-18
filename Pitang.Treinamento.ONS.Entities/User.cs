using System;
using System.ComponentModel.DataAnnotations;

namespace Pitang.Treinamento.ONS.Entities
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório")]
        [MaxLength(20, ErrorMessage = "Limite máximo atingido")]
        [MinLength(3, ErrorMessage = "Limite mínimo não atingido")]
        public String FirstName { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório")]
        [MaxLength(20, ErrorMessage = "Limite máximo atingido")]
        [MinLength(3, ErrorMessage = "Limite mínimo não atingido")]
        public String LastName { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório")]
        [MaxLength(20, ErrorMessage = "Limite máximo atingido")]
        [MinLength(3, ErrorMessage = "Limite mínimo não atingido")]
        public String Email { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório")]
        [MaxLength(20, ErrorMessage = "Limite máximo atingido")]
        [MinLength(3, ErrorMessage = "Limite mínimo não atingido")]
        public String Password { get; set; }

    }
}

using System;
using System.Collections.Generic;
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
        public String UserName { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório")]
        [MaxLength(20, ErrorMessage = "Limite máximo atingido")]
        [MinLength(3, ErrorMessage = "Limite mínimo não atingido")]
        [EmailAddress(ErrorMessage = "Email não possui o formato correto")]
        public String Email { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório")]
        [MaxLength(20, ErrorMessage = "Limite máximo atingido")]
        [MinLength(3, ErrorMessage = "Limite mínimo não atingido")]
        public String Password { get; set; }

        public List<Contact> ContactsUser { get; set; }
        public List<Messages> MessagesUser { get; set; }
        public List<Story> StoriesUser { get; set; }




    }
}

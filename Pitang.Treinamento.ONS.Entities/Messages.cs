using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Pitang.Treinamento.ONS.Entities
{
    
     public class Messages
        {
            public Messages()
            {
                this.Publicate = DateTime.Now;
            }

            [Key]
            public int Id { get; set; }


            [Required(ErrorMessage = "Este campo é obrigatório")]
            [MaxLength(60, ErrorMessage = "Este campo deve conter entre 3 e 60 caracteres.")]
            [MinLength(3, ErrorMessage = "Este campo deve conter entre 3 e 60 caracteres.")]
            public string Message { get; set; }


            [Required(ErrorMessage = "Este campo é obrigatório")]
            [Range(1, int.MaxValue, ErrorMessage = "O campo deve ser maior ou igual a 1")]
            public int IdOwner { get; set; }

            [Required(ErrorMessage = "Este campo é obrigatório")]
            [Range(1, int.MaxValue, ErrorMessage = "O campo deve ser maior ou igual a 1")]
            public int IdTarget { get; set; }


            public DateTime Publicate { get; set; }
        }
    }



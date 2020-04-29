using System.ComponentModel.DataAnnotations;

namespace Treinamento.Pitang.ONS.Entities
{
    public abstract class BaseEntity
    {
        [Key]
        public int Id { get; set; }

        public bool IsDeleted { get; set; }
    }
}

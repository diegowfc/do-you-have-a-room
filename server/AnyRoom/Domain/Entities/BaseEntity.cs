using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    public class BaseEntity
    {
        [Key]
        public virtual int ID { get; set; }
    }
}

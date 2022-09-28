using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebShop.Entity
{
    [Table("Expences")]
    public class Expence
    {
        [Key]
        public int Id { get; set; }

        public int ParentId { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
    }
}

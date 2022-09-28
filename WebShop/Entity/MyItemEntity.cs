using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebShop.Entity
{
    [Table("MyItemEntities")]
    public class MyItemEntity
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Borrower { get; set; }

        public string Lender { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DecouverteEntityFrameworkCodeFirst
{
    public class Item
    {
        [Key] // optionnel. par convention EF utilise Id ou ItemId
        public int Id { get; set; }

        [Required]
        [MaxLength(20)]
        public string Name { get; set; }

        [MaxLength(200)]
        public string Description { get; set; }

        [Column(TypeName = "decimal(7,2)")]
        public decimal Price { get; set; }

    }
}

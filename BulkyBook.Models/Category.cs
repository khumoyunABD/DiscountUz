using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace DiscountUz.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [DisplayName("Display Order")]
        [Range(1, 150, ErrorMessage = "Display Order can be between 1 and 150 only!!!")]
        public int DisplayOrder { get; set; }
        public DateTime CreatedDateTime { get; set; } = DateTime.Now;
    }
}

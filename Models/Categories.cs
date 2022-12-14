using System.ComponentModel.DataAnnotations;

namespace kapraMarket.web.Models
{
    public class Categories
    {
        [Required]
        [Key]
        public int categoryId { get; set; }
        [Required]
        public string categoryName { get; set; }
        [Required]
        public string categoryDescription { get; set; }
    }
}

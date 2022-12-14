using System.ComponentModel.DataAnnotations;

namespace kapraMarket.web.Models
{
    public class Products
    {
        [Required]
        [Key]
        public int productId { get; set; }
        [Required]
        public string productName { get; set; }
        [Required]
        public int productQuantity { get; set; }
        [Required]
        public float productPrice { get; set; }
        [Required]
        public string productDescription { get; set; }
    }
}

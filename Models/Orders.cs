using System.ComponentModel.DataAnnotations;

namespace kapraMarket.web.Models
{
    public class Orders
    {
        [Required]
        [Key]
        public int OrderId { get; set; }
        [Required]
        public int UserId { get; set; }
        [Required]
        public DateTime CreatedAt { get; set; }
    }
}

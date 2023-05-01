using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Urban.Models
{
   
        public class Order
        {
            [Key]
            public int OrderId { get; set; }

            public string? Email { get; set; }

            public string? UserId { get; set; }
        [ForeignKey(nameof(UserId))]
        public ApplicationUser User { get; set; }
        public List<OrderItem> OrderItem { get; set; }
    }
    }


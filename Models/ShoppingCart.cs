using System.ComponentModel.DataAnnotations;

namespace Urban.Models
{
    public class ShoppingCart
    {
        [Key]
        public int Id { get; set; }
        public int Product { get; set; }
        public int Amount { get; set; }

        public string ShoppingCartId {get; set; }
    }
}

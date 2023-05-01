using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Urban.Models
{
    public class OrderItem
    {
        [Key]
        public int OrderId { get; set; }
        public int Amount{ get; set; }
        public double Price{ get; set; }
        public int Id { get; set; }
        [ForeignKey("Id")]
        public Product Product { get; set; }

        public int Oid { get; set; }
        [ForeignKey("Oid")]
        public Order Order{ get; set; }






        public OrderItem()
        {

        }

    }
}
    


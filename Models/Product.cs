using System.ComponentModel.DataAnnotations;
namespace Urban.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        [Display(Name ="Product Name")]
        public string? ProductName { get; set; }
        [Display(Name = "Product Description")]

        public string? ProductDescrition { get; set; }
        [Display(Name = "Product Price")]
        public int Productprice { get; set; }
        [Display(Name = "Product Image")]
        public string? ProductImage { get; set; }




        public Product()
        {

        }
    }
}

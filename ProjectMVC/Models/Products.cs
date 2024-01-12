using System.ComponentModel.DataAnnotations;

namespace ProjectMVC.Models
{
    public class Products
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        [DataType(DataType.Date)] 
        public string Description { get; set; }
        public string Image { get; set; }
        public decimal Quantity { get; set; }
        public decimal Price { get; set; }
    }
}

namespace api_ecommerce.Models
{
    public class Category
    {
        public ICollection<Product> Products { get; set; }
    }
}

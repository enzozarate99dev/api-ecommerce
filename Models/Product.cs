using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel;

namespace api_ecommerce.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductSku { get; set; }
        public string ProductDescription { get; set; }
        public string ProductPrice { get; set; }
        public string ProductShortName { get; set; }
        public int CategoryId { get; set; }
        public string CategoryName { get; set;}
        public DateTime CreateDate { get; set; }
        public string DeliveryTimeSpan { get; set; }
        public string ProductImageUrl { get; set; }
        public virtual Category Category { get; set; }
    }
    public class PeliculaConfig : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable("Product");
            builder.HasKey(x => x.ProductId);
            builder.Property(x => x.ProductId).HasColumnName("ProductId").IsRequired();   
            builder.HasOne(x => x.Category).WithMany(c => c.Products).HasForeignKey(p => p.CategoryId);
        }

       
    }
}

﻿namespace api_ecommerce.DTOs.Responses
{
    public class ProductRequest
    {
        public string ProductName { get; set; }
        public string ProductSku { get; set; }
        public string ProductDescription { get; set; }
        public string ProductPrice { get; set; }
        public string ProductShortName { get; set; }
        public int CategoryId { get; set; }
        public DateTime CreateDate { get; set; }
        public string DeliveryTimeSpan { get; set; }
        public string ProductImageUrl { get; set; }
    }
}

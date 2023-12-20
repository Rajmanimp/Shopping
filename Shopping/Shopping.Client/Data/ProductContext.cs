using Shopping.Client.Models;

namespace Shopping.Client.Data
{
    public static class ProductContext
    {
        public static readonly List<Product> products = new List<Product>()
        {
            new Product()
            {
                Name = "Iphone X",
                Description = "Phone Description",
                ImageFile = "product1.png",
                Price = 100.00M,
                Category = "Smart Phone"
            },
            new Product()
            {
                Name = "Samsung Galaxy S21",
                Description = "Phone Description",
                ImageFile = "product1.png",
                Price = 150.00M,
                Category = "Smart Phone"
            }
        };
    }
}

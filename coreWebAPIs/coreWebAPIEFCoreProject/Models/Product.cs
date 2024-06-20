namespace coreWebAPIEFCoreProject.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string? Name { get; set; }
        public double Price { get; set; }

        // Foreign Keys
        public int CategoryId { get; set; }
        public int BrandId { get; set; }

        public Category? Category { get; set; }
        public Brand? Brand { get; set; }
    }
}

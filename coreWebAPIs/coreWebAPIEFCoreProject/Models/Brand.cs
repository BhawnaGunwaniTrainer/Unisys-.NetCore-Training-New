namespace coreWebAPIEFCoreProject.Models
{
    public class Brand
    {
        public int BrandId { get; set; }
        public string? Name { get; set; }

        // Navigation Properties
        public ICollection<Product>? Products { get; set; }
    }
}

namespace coreWebAPIEFCoreProject.Models
{
    public class Category
    {
        // Scalar Properties
        public int CategoryId { get; set; }
        public string? Name { get; set; }

        // Navigation Properties
        public ICollection<Product>? Products { get; set; }

    }
}

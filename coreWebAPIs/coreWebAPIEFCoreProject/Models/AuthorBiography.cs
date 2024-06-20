using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace coreWebAPIEFCoreProject.Models
{
    public class AuthorBiography
    {
        // [Key]
        public int BioId { get; set; }
        public int age { get; set; }
    }
}

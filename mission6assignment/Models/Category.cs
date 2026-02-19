using System.ComponentModel.DataAnnotations;

namespace mission6assignment.Models
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }

        [Required]
        public string? CategoryName { get; set; }

        // Navigation property
        public List<Movie>? Movies { get; set; }
    }
}
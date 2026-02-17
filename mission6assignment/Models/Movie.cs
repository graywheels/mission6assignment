using System.ComponentModel.DataAnnotations;

namespace mission6assignment.Models
{
    public class Movie
    {
        // Primary Key (matches database)
        [Key]
        public int MovieId { get; set; }

        // Foreign key to Categories table (exists in DB)
        public int? CategoryId { get; set; }

        // REQUIRED FIELDS PER ASSIGNMENT
        [Required(ErrorMessage = "Title is required.")]
        public string? Title { get; set; }

        [Required(ErrorMessage = "Year is required.")]
        [Range(1888, 2100, ErrorMessage = "Year must be 1888 or later.")]
        public int? Year { get; set; }

        [Required(ErrorMessage = "Edited selection is required.")]
        public bool? Edited { get; set; }

        [Required(ErrorMessage = "CopiedToPlex selection is required.")]
        public bool? CopiedToPlex { get; set; }

        // Optional fields (based on DB allowing NULLs)
        public string? Director { get; set; }

        public string? Rating { get; set; }

        public string? LentTo { get; set; }

        [MaxLength(25)]
        public string? Notes { get; set; }
    }
}
namespace mission6assignment.Models;
using System.ComponentModel.DataAnnotations;

public class Movie
{
    [Key]
    [Required]
    public int MovieId { get; set; } // Primary Key

    [Required]
    public string Category { get; set; }

    [Required]
    public string Title { get; set; }

    [Required]
    [Range(1888, 2100)] // Validates a realistic year
    public int Year { get; set; }

    [Required]
    public string Director { get; set; }

    [Required]
    public string Rating { get; set; } // Dropdown: G, PG, PG-13, R

    public bool Edited { get; set; } // true/false

    public string? LentTo { get; set; } // Optional (?)

    [MaxLength(25)] // Limits notes to 25 characters
    public string? Notes { get; set; } // Optional
}
using System.ComponentModel.DataAnnotations;

namespace BlazorMvc.Frontend;

public class GameDetails
{
    public int Id { get; set; }

    [Required(ErrorMessage = "Name field is required")]
    [StringLength(50)]
    public required string Name { get; set; }

    [Required(ErrorMessage = "Genre field is required")]
    public string? GenreId { get; set; }
    
    [Required(ErrorMessage = "Price field is required")]
    [Range(1, 100)]
    public decimal Price { get; set; }

    public DateOnly ReleaseDate { get; set; }
}

using System.ComponentModel.DataAnnotations;

namespace Banana_King.Models
{
    public class Banana
    {

        [Required]
        public int Id { get; set; }
        public string? SortName { get; set; } = string.Empty;

        public string? Description { get; set; } = string.Empty;

        [Range(0.1, 99.99)]
        public decimal? Price { get; set; }

        public string? Img { get; set; }
    }
}

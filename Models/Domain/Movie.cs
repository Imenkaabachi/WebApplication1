using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Build.Framework;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models.Domain
{
    public class Movie
    {
        public int Id { get; set; }
        [Required]

        public string? Title { get; set; }
        [Required]
        public string? ReleaseYear { get; set; }
        [Required]
        public string? MovieImage { get; set; }
        [Required]

        public string? Cast { get; set; }
        [Required]

        public string? Director { get; set; }
        
        [NotMapped]
        public IFormFile? ImageFile { get; set; }

        [Required]
        [NotMapped] 
        public List<int>? Genres { get; set; }
        public IEnumerable<SelectListItem>? GenreList {get;set; }

        [NotMapped]
        public string? GenreNames { get; set; }
        public MultiSelectList? MultiGenreList { get; set; }
    }
}

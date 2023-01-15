using Microsoft.Build.Framework;

namespace WebApplication1.Models
{
    public class MovieGenre
    {
        public int Id { get; set; }
        [Required]

        public int MovieId { get; set; }
        [Required]

        public int GenreId { get; set; }


    }
}

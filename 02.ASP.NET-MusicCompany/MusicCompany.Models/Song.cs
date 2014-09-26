namespace MusicCompany.Models
{
    using System.ComponentModel.DataAnnotations;

    public class Song
    {
        public int Id { get; set; }

        [Required]
        [MinLength(2)]
        [MaxLength(50)]
        public string Title { get; set; }

        [Required]
        [Range(1800, 2050)]
        public int Year { get; set; }

        public string Genre { get; set; }

        public int ArtistId { get; set; }

        public virtual Artist Artist { get; set; }

        public int AlbumId { get; set; }

        public virtual Album Album { get; set; }
    }
}

namespace MusicCompany.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Artist
    {
        private ICollection<Song> songs;
        private ICollection<Album> albums;

        public Artist()
        {
            this.songs = new HashSet<Song>();
            this.albums = new HashSet<Album>();
        }

        public int Id { get; set; }

        [Required]
        [MinLength(2)]
        [MaxLength(20)]
        public string Name { get; set; }

        [Required]
        [MinLength(2)]
        [MaxLength(20)]
        public string Country { get; set; }

        public DateTime? BirthDate { get; set; }

        public ICollection<Song> Songs
        {
            get { return this.songs; }
            set { this.songs = value; }
        }

        public ICollection<Album> Albums
        {
            get { return this.albums; }
            set { this.albums = value; }
        }
    }
}

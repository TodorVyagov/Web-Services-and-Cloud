namespace MusicCompany.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Album
    {
        private ICollection<Song> songs;
        private ICollection<Artist> artists;

        public Album()
        {
            this.songs = new HashSet<Song>();
            this.artists = new HashSet<Artist>();
        }

        public int Id { get; set; }

        [Required]
        [MinLength(2)]
        [MaxLength(20)]
        public string Title { get; set; }

        [Required]
        [Range(1800, 2050)]
        int Year { get; set; }

        public string Producer { get; set; }

        public ICollection<Song> Songs
        {
            get { return this.songs; }
            set { this.songs = value; }
        }

        public ICollection<Artist> Artists
        {
            get { return this.artists; }
            set { this.artists = value; }
        }
    }
}

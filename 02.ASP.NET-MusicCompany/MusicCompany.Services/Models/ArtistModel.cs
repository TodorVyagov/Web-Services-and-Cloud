namespace MusicCompany.Services.Models
{
    using Antlr.Runtime.Misc;
    using MusicCompany.Models;
    using System.ComponentModel.DataAnnotations;
    using System.Linq.Expressions;

    public class ArtistModel
    {
        public static Expression<Func<Artist, ArtistModel>> FromFromArtist
        {
            get
            {
                return a => new ArtistModel
                {
                    Id = a.Id,
                    Name = a.Name,
                    Country = a.Country
                };
            }
        }

        public int Id { get; set; }

        public string Name{ get; set; }

        public string Country { get; set; }
    }
}
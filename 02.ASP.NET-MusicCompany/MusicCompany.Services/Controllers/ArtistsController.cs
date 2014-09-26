namespace MusicCompany.Services.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Net;
    using System.Net.Http;
    using System.Web.Http;

    using MusicCompany.Data;
    using MusicCompany.Models;
    using MusicCompany.Services.Models;

    public class ArtistsController : ApiController
    {
        private IMusicCompanyData data;

        public ArtistsController()
            : this(new MusicCompanyData())
        {
        }

        public ArtistsController(IMusicCompanyData data)
        {
            this.data = data;
        }

        [HttpPost]
        public IHttpActionResult Create(ArtistModel artist)
        {
            if (!this.ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var createdArtist = new Artist
            {
                Name = artist.Name,
                Country = artist.Country
            };

            this.data.Artists.Add(createdArtist);
            this.data.SaveChanges();

            artist.Id = createdArtist.Id;
            return Ok(artist);
        }
    }
}

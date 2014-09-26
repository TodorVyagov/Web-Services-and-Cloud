namespace MusicCompany.Data
{
    using MusicCompany.Data.Repositories;
    using MusicCompany.Models;

    public interface IMusicCompanyData
    {
        IRepository<Artist> Artists { get; }

        IRepository<Album> Albums { get; }

        void SaveChanges();
    }
}

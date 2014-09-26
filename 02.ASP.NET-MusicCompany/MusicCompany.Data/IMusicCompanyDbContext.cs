namespace MusicCompany.Data
{
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;

    using MusicCompany.Models;

    public interface IMusicCompanyDbContext
    {
        IDbSet<Artist> Artists { get; set; }

        IDbSet<Album> Albums { get; set; }

        IDbSet<Song> Songs { get; set; }

        void SaveChanges();

        IDbSet<TEntity> Set<TEntity>() where TEntity : class;

        DbEntityEntry<TEntity> Entry<TEntity>(TEntity entity) where TEntity : class;
    }
}
